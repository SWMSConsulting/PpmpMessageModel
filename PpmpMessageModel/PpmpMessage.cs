using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PpmpMessageModel
{
    public abstract class PpmpMessage
    {
        [JsonProperty(PropertyName = "content-spec")]
        public abstract string contentSpec { get; }

        [JsonProperty(PropertyName = "device")]
        public Device Device { get; set; }

    }
}
