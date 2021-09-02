using Newtonsoft.Json;
using PpmpMessageModel.Enums;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace PpmpMessageModel
{
    public class TimeMeasurement
    {
        [JsonProperty(PropertyName = "code")]
        public string? Code { get; set; }

        [JsonProperty(PropertyName = "context")]
        public Dictionary<string, PpmpContext>? Context { get; set; }

        [JsonProperty(PropertyName = "result")]
        public Result? Result { get; set; }

        [JsonProperty(PropertyName = "series")]
        public TimeSeries Series { get; set; }

        [JsonProperty(PropertyName = "ts")]
        public DateTime Ts { get; set; }

        [JsonProperty(PropertyName = "additionalData")]
        public ExpandoObject? AdditionalData { get; set; }

    }
}