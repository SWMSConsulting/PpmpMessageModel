using Newtonsoft.Json;
using PpmpMessageModel.Enums;
using System;
using System.Dynamic;

namespace PpmpMessageModel
{
    public class Process
    {
        [JsonProperty(PropertyName = "externalId")]
        public string? ExternalId { get; set; }

        [JsonProperty(PropertyName = "program")]
        public Program? Program { get; set; }

        [JsonProperty(PropertyName = "result")]
        public Result? Result { get; set; }

        [JsonProperty(PropertyName = "ts")]
        public DateTime Ts { get; set; }

        [JsonProperty(PropertyName = "additionalData")]
        public ExpandoObject? AdditionalData { get; set; }
    }
}