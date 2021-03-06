using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class FoundMessages : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "foundMessages";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("messages")]
            public Message[] Messages { get; set; }

            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("next_from_search_id")]
            public Int64 NextFromSearchId { get; set; }
        }
    }
}