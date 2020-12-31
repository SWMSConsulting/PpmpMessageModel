using Newtonsoft.Json;
using System;
using System.Dynamic;

namespace PpmpMessageModel
{
    public class Program
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "lastChangeData")]
        public DateTime? LastChangeDate { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }

        [JsonProperty(PropertyName = "additionalData")]
        public ExpandoObject? AdditionalData { get; set; }
    }
}