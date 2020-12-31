using Newtonsoft.Json;
using System.Collections.Generic;

namespace PpmpMessageModel
{
    public class SpecialValue
    {
        [JsonProperty(PropertyName = "time")]
        public int? Time { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }

        [JsonProperty(PropertyName = "values")]
        public List<object> Values { get; set; }
    }
}