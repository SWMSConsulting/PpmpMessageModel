using Newtonsoft.Json;

namespace PpmpMessageModel
{
    public class Limit
    {
        [JsonProperty(PropertyName = "lowerError")]
        public float? LowerError { get; set; }

        [JsonProperty(PropertyName = "lowerWarn")]
        public float? LowerWarn { get; set; }

        [JsonProperty(PropertyName = "target")]
        public float? Target { get; set; }

        [JsonProperty(PropertyName = "upperError")]
        public float? UpperError { get; set; }

        [JsonProperty(PropertyName = "upperWarn")]
        public float? UpperWarn { get; set; }

    }
}