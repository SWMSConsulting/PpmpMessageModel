using Newtonsoft.Json;
using PpmpMessageModel.Enums;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace PpmpMessageModel
{
    public class Device
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "mode")]
        public string? Mode { get; set; }

        [JsonProperty(PropertyName = "state")]
        public DeviceState? State { get; set; }

        [JsonProperty(PropertyName = "additionalData")]
        public ExpandoObject? AdditionalData { get; set; }
    }
}
