#pragma warning disable 1591 // Missing XML comment for publicly visible type or member

using System;
using Newtonsoft.Json.Linq;

namespace RethinkDb.Driver.Model
{
    /*
            r.path("contact", "phone", "work");
            r.path("contact", "phone", r.paths("work", "home"));
            r.path("contact",
                r.paths(
                    r.path("phone",
                        r.paths("work", "home")),
                r.paths(
                    r.path("im", "skype")),
            );
    
    */


    //not sure what this is about.. so ignore it for now.
    public class PathSpec
    {
        private readonly JObject root = new JObject();

        private PathSpec()
        {
        }

        public virtual PathSpec path(string start, params PathSpec[] specs)
        {
            throw new Exception("not implemented");
        }

        public virtual PathSpec path(params string[] strings)
        {
            throw new Exception("not implemented");
        }
    }
}