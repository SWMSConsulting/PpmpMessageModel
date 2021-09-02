using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace PpmpMessageModel.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ValueType
    {
        BASE64, BOOLEAN, NUMBER, OTHER, REF, STRING
    }
}
