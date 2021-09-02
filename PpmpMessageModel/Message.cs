using Newtonsoft.Json;
using PpmpMessageModel.Enums;
using System;
using System.Dynamic;

namespace PpmpMessageModel
{
    public class Message
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }

        [JsonProperty(PropertyName = "hint")]
        public string? Hint { get; set; }

        [JsonProperty(PropertyName = "origin")]
        public string? Origin { get; set; }

        [JsonProperty(PropertyName = "severity")]
        public Severity? Severity { get; set; }

        [JsonProperty(PropertyName = "source")]
        public Source? Source { get; set; }

        [JsonProperty(PropertyName = "state")]
        public State? State { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "ts")]
        public DateTime Ts { get; set; }

        [JsonProperty(PropertyName = "type")]
        public MessageType? Type { get; set; }

        [JsonProperty(PropertyName = "additionalData")]
        public ExpandoObject? AdditionalData { get; set; }





    }
}