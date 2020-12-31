using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PpmpMessageModel
{
    public class PpmpMeasurementMessage : PpmpMessage
    {
        public override string contentSpec { get => "urn:spec://eclipse.org/unide/measurement-message#v3"; }

        [JsonProperty(PropertyName = "measurements")]
        public List<TimeMeasurement> Measurements { get; set; }

        [JsonProperty(PropertyName = "part")]
        public Part? Part { get; set; }
    }
}
