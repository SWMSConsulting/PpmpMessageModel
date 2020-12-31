using Newtonsoft.Json;

namespace PpmpMessageModel
{
    public class Limit
    {
        [JsonProperty(PropertyName = "lowError")]
        public float? LowError { get; set; }

        [JsonProperty(PropertyName = "lowWarn")]
        public float? LowWarn { get; set; }

        [JsonProperty(PropertyName = "target")]
        public float? Target { get; set; }

        [JsonProperty(PropertyName = "upperError")]
        public float? UpperError { get; set; }

        [JsonProperty(PropertyName = "upperWarn")]
        public float? UpperWarn { get; set; }

    }
}