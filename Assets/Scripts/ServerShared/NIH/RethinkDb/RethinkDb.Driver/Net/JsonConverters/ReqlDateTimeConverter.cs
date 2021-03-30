#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RethinkDb.Driver.Net.JsonConverters
{
    public class ReqlDateTimeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName(Converter.PseudoTypeKey);
            writer.WriteValue(Converter.Time);
            writer.WritePropertyName("epoch_time");
            DateTimeOffset dto;
            if( value is DateTimeOffset )
            {
                dto = (DateTimeOffset)value;
            }
            else //value is DateTime
            {
                var dt = (DateTime)value;
                if( dt == DateTime.MinValue )
                { //Ugh. Make MinValue consistent cross-platform on Windows and Linux.
                  //See: https://github.com/dotnet/corefx/issues/9019
                  //     https://github.com/bchavez/RethinkDb.Driver/issues/66
                  //Either way, we shunt the value to MinValue and avoid
                  //conversion of MinValue.
                    dto = DateTimeOffset.MinValue;
                }
                else
                {
                    dto = new DateTimeOffset((DateTime)value);
                }
            }
            writer.WriteValue(ToUnixTime(dto));
            writer.WritePropertyName("timezone");
            var offset = $"{(dto.Offset < TimeSpan.Zero ? "-" : "+")}{dto.Offset.ToString("hh':'mm")}";
            writer.WriteValue(offset);
            writer.WriteEndObject();
        }

        //http://stackoverflow.com/questions/2883576/how-do-you-convert-epoch-time-in-c
        public static double ToUnixTime(DateTimeOffset date)
        {
            return ToUnixTime(date.UtcTicks);
        }

        public static double ToUnixTime(long utcTicks)
        {
            return (utcTicks - 621355968000000000) / 10000000.0;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if( reader.TokenType == JsonToken.Null )
            {
                return null;
            }

            if( reader.TokenType != JsonToken.StartObject )
            {
                var msg = string.Join(" ",
                    $"The JSON representation of a DateTime/DateTimeOffset when parsing the server response is not a {Converter.PseudoTypeKey}:{Converter.Time} object.",
                    $"This happens if your JSON document contains DateTime/DateTimeOffsets in some other format (like an ISO8601 string) rather than a native RethinkDB pseudo type {Converter.PseudoTypeKey}:{Converter.Time} object.",
                    $"If you are overriding the default Ser/Deserialization process, you need to make sure DateTime/DateTimeOffset are native {Converter.PseudoTypeKey}:{Converter.Time} objects before using the built-in {nameof(ReqlDateTimeConverter)}.",
                    "See https://rethinkdb.com/docs/data-types/ for more information about how Date and Times are represented in RethinkDB.");
                throw new JsonSerializationException(msg);
            }

            reader.ReadAndAssertProperty(Converter.PseudoTypeKey);
            var reql_type = reader.ReadAsString();
            if( reql_type != Converter.Time )
            {
                throw new JsonSerializationException($"Expected {Converter.PseudoTypeKey} should be {Converter.Time} but got {reql_type}.");
            }

            reader.ReadAndAssertProperty("epoch_time");
            var epoch_time = reader.ReadAsDouble();
            if( epoch_time == null )
            {
                throw new JsonSerializationException($"The {Converter.PseudoTypeKey}:{Converter.Time} object doesn't have an epoch_time value.");
            }

            reader.ReadAndAssertProperty("timezone");
            var timezone = reader.ReadAsString();

            //realign and get out of the pseudo type
            //one more post read to align out of { reql_type:TIME,  .... } 
            reader.ReadAndAssert();

            if( objectType == typeof(DateTimeOffset) ||
                objectType == typeof(DateTimeOffset?) )
            {
                return ConvertDateTimeOffset(epoch_time.Value, timezone);
            }
            else
            {
                return ConvertDateTime(epoch_time.Value, timezone, serializer.DateTimeZoneHandling);
            }
        }

        public static DateTimeOffset ConvertDateTimeOffset(double epoch_time, string timezone)
        {
            var tz = TimeSpan.Parse(timezone.Substring(1));
            if (!timezone.StartsWith("+"))
                tz = -tz;

            var epoch = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);
            var dt = epoch + TimeSpan.FromSeconds(epoch_time);

            return dt.ToOffset(tz);
        }

        public static DateTime ConvertDateTime(double epoch_time, string timezone, DateTimeZoneHandling tzHandle)
        {
            var dto = ConvertDateTimeOffset(epoch_time, timezone);
            switch (tzHandle)
            {
                case DateTimeZoneHandling.Local:
                    return dto.LocalDateTime;
                case DateTimeZoneHandling.Utc:
                    return dto.UtcDateTime;
                case DateTimeZoneHandling.Unspecified:
                    return dto.DateTime;
                case DateTimeZoneHandling.RoundtripKind:
                    return dto.Offset == TimeSpan.Zero ? dto.UtcDateTime : dto.LocalDateTime;
                default:
                    throw new JsonSerializationException("Invalid date time handling value.");
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime) ||
                   objectType == typeof(DateTimeOffset) ||
                   objectType == typeof(DateTime?) ||
                   objectType == typeof(DateTimeOffset?);
        }
    }
}