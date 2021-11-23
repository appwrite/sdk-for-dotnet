
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class Log
    {
        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("osCode")]
        public string OsCode { get; set; }

        [JsonProperty("osName")]
        public string OsName { get; set; }

        [JsonProperty("osVersion")]
        public string OsVersion { get; set; }

        [JsonProperty("clientType")]
        public string ClientType { get; set; }

        [JsonProperty("clientCode")]
        public string ClientCode { get; set; }

        [JsonProperty("clientName")]
        public string ClientName { get; set; }

        [JsonProperty("clientVersion")]
        public string ClientVersion { get; set; }

        [JsonProperty("clientEngine")]
        public string ClientEngine { get; set; }

        [JsonProperty("clientEngineVersion")]
        public string ClientEngineVersion { get; set; }

        [JsonProperty("deviceName")]
        public string DeviceName { get; set; }

        [JsonProperty("deviceBrand")]
        public string DeviceBrand { get; set; }

        [JsonProperty("deviceModel")]
        public string DeviceModel { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("countryName")]
        public string CountryName { get; set; }


        public Log(
            string xevent,
            string ip,
            int time,
            string osCode,
            string osName,
            string osVersion,
            string clientType,
            string clientCode,
            string clientName,
            string clientVersion,
            string clientEngine,
            string clientEngineVersion,
            string deviceName,
            string deviceBrand,
            string deviceModel,
            string countryCode,
            string countryName
        ) {
            Event = xevent;
            Ip = ip;
            Time = time;
            OsCode = osCode;
            OsName = osName;
            OsVersion = osVersion;
            ClientType = clientType;
            ClientCode = clientCode;
            ClientName = clientName;
            ClientVersion = clientVersion;
            ClientEngine = clientEngine;
            ClientEngineVersion = clientEngineVersion;
            DeviceName = deviceName;
            DeviceBrand = deviceBrand;
            DeviceModel = deviceModel;
            CountryCode = countryCode;
            CountryName = countryName;
        }

        public static Log From(Dictionary<string, object> map) => new Log(
            xevent: (string)map["event"],
            ip: (string)map["ip"],
            time: (int)map["time"],
            osCode: (string)map["osCode"],
            osName: (string)map["osName"],
            osVersion: (string)map["osVersion"],
            clientType: (string)map["clientType"],
            clientCode: (string)map["clientCode"],
            clientName: (string)map["clientName"],
            clientVersion: (string)map["clientVersion"],
            clientEngine: (string)map["clientEngine"],
            clientEngineVersion: (string)map["clientEngineVersion"],
            deviceName: (string)map["deviceName"],
            deviceBrand: (string)map["deviceBrand"],
            deviceModel: (string)map["deviceModel"],
            countryCode: (string)map["countryCode"],
            countryName: (string)map["countryName"]
        );

        public Dictionary<string, object> ToMap() => new Dictionary<string, object>()
        {
            { "event", Event },
            { "ip", Ip },
            { "time", Time },
            { "osCode", OsCode },
            { "osName", OsName },
            { "osVersion", OsVersion },
            { "clientType", ClientType },
            { "clientCode", ClientCode },
            { "clientName", ClientName },
            { "clientVersion", ClientVersion },
            { "clientEngine", ClientEngine },
            { "clientEngineVersion", ClientEngineVersion },
            { "deviceName", DeviceName },
            { "deviceBrand", DeviceBrand },
            { "deviceModel", DeviceModel },
            { "countryCode", CountryCode },
            { "countryName", CountryName }
        };
    }
}