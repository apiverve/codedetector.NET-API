using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("likelihood")]
    public double likelihood { get; set; }

    [JsonProperty("family")]
    public string family { get; set; }

    [JsonProperty("current")]
    public string current { get; set; }

    [JsonProperty("readable")]
    public string readable { get; set; }

    [JsonProperty("extension")]
    public string extension { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
