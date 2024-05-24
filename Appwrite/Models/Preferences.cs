
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Preferences
    {
        public Dictionary<string, object> Data { get; private set; }

        public Preferences(
            Dictionary<string, object> data
        ) {
            Data = data;
        }

        public static Preferences From(Dictionary<string, object> map) => new Preferences(
            data: map
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "data", Data }
        };

        public T ConvertTo<T>(Func<Dictionary<string, object>, T> fromJson) =>
            fromJson.Invoke(Data);
    }
}