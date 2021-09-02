using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PpmpMessageModel
{
    public class TimeSeries : Dictionary<string, List<object>>
    {
        [JsonProperty(PropertyName = "time")]
        public List<int> Time
        {
            get
            {
                if (this.ContainsKey("time"))
                {
                    return this["time"].Select(i => Convert.ToInt32(i)).ToList();
                }
                return new List<int>();
            }
        }
    }
}
