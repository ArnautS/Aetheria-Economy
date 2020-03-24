#pragma warning disable 1591 // Missing XML comment for publicly visible type or member

using Newtonsoft.Json.Linq;

namespace RethinkDb.Driver.Model
{
    public class Profile
    {
        public Profile(JArray profileObj)
        {
            this.ProfileObj = profileObj;
        }

        public JArray ProfileObj { get; }

        public static Profile FromJsonArray(JArray profileObj)
        {
            if( profileObj == null || profileObj.Count == 0 )
            {
                return null;
            }
            return new Profile(profileObj);
        }
    }
}