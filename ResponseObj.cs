using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("likelihood")]
        public double Likelihood { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("current")]
        public string Current { get; set; }

        [JsonProperty("readable")]
        public string Readable { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
