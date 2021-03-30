﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RethinkDb.Driver.Net;

namespace RethinkDb.Driver.Model
{
    /// <summary>
    /// A type helper that represents the result of <see cref="Connection.Server"/>
    /// and <seealso cref="Connection.ServerAsync"/>.
    /// </summary>
    public class Server
    {
        /// <summary>
        /// The server's id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The server's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// True if the driver is connected to a proxy server. False if the driver is
        /// connected to a RethinkDB server.
        /// </summary>
        public bool Proxy { get; set; }

        /// <summary>
        /// Extra metadata that couldn't be parsed, if any.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, JToken> ExtraData { get; set; }
    }
}