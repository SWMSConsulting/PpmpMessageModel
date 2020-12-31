using Newtonsoft.Json;
using PpmpMessageModel.Enums;
using System.Dynamic;

namespace PpmpMessageModel
{
    public class Part
    {
        [JsonProperty(PropertyName = "code")]
        public string? Code { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }

        [JsonProperty(PropertyName = "type")]
        public PartType? Type { get; set; }

        [JsonProperty(PropertyName = "typeId")]
        public string? TypeId { get; set; }

        [JsonProperty(PropertyName = "result")]
        public Result Result { get; set; }

        [JsonProperty(PropertyName = "additionalData")]
        public ExpandoObject? AdditionalData { get; set; }
    }
}