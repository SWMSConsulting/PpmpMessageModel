using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace PpmpMessageModel
{
    public class PpmpContext
    {
        [JsonProperty(PropertyName = "limits")]
        public Limit? Limits { get; set; }

        [JsonProperty(PropertyName = "namespace")]
        public string? Namespace { get; set; }

        [JsonProperty(PropertyName = "type")]
        public ValueType? Type { get; set; }

        [JsonProperty(PropertyName = "unit")]
        public string? Unit { get; set; }

        [JsonProperty(PropertyName = "additionalData")]
        public ExpandoObject? AdditionalData { get; set; }
    }
}