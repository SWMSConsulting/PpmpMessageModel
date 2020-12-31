using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PpmpMessageModel
{
    public class PpmpMachineMessage: PpmpMessage
    {
        public override string contentSpec { get => "urn:spec://eclipse.org/unide/machine-message#v3"; }

        [JsonProperty(PropertyName = "messages")]
        public List<Message> Messages { get; set; }
    }
}
