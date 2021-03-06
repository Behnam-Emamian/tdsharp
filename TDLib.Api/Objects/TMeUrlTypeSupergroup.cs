using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class TMeUrlType : Object
        {
            public class TMeUrlTypeSupergroup : TMeUrlType
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "tMeUrlTypeSupergroup";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("supergroup_id")]
                public long SupergroupId { get; set; }
            }
        }
    }
}