using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PpmpMessageModel
{
    public class PpmpProcessMessage : PpmpMessage
    {
        public override string contentSpec { get => "urn:spec://eclipse.org/unide/process-message#v3"; }

        [JsonProperty(PropertyName = "measurements")]
        public List<ProcessMeasurement> Measurements { get; set; }

        [JsonProperty(PropertyName = "part")]
        public Part? Part { get; set; }

        [JsonProperty(PropertyName = "process")]
        public Process? Process { get; set; }
    }
}
