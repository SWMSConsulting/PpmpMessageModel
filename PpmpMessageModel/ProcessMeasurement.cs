using Newtonsoft.Json;
using PpmpMessageModel.Enums;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace PpmpMessageModel
{
    public class ProcessMeasurement
    {
        [JsonProperty(PropertyName = "code")]
        public string? Code { get; set; }

        [JsonProperty(PropertyName = "context")]
        public List<Context> Context { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }

        [JsonProperty(PropertyName = "phase")]
        public string? Phase { get; set; }

        [JsonProperty(PropertyName = "result")]
        public Result? Result { get; set; }

        [JsonProperty(PropertyName = "series")]
        public TimeSeries Series { get; set; }

        [JsonProperty(PropertyName = "specialValues")]
        public List<SpecialValue> SpecialValues { get; set; }

        [JsonProperty(PropertyName = "ts")]
        public DateTime Ts { get; set; }

        [JsonProperty(PropertyName = "additionalData")]
        public ExpandoObject? AdditionalData { get; set; }

    }
}