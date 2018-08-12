using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class TextEntityType : Object
        {
            public class TextEntityTypeMentionName : TextEntityType
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "textEntityTypeMentionName";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_id")]
                public int UserId { get; set; }
            }
        }
    }
}