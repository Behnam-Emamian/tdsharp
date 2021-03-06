using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class SetSupergroupDescription : Function<Ok>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "setSupergroupDescription";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("supergroup_id")]
            public int SupergroupId { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("description")]
            public string Description { get; set; }
        }
    }
}