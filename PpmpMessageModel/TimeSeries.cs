using Newtonsoft.Json;
using System.Collections.Generic;

namespace PpmpMessageModel
{
    public class TimeSeries
    {
        [JsonProperty(PropertyName = "time")]
        public int Time { get; set; }

        [JsonProperty(PropertyName = "values")]
        public List<object> Values { get; set; }
    }
}