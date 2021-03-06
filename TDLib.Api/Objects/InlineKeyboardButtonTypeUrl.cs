using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class InlineKeyboardButtonType : Object
        {
            public class InlineKeyboardButtonTypeUrl : InlineKeyboardButtonType
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "inlineKeyboardButtonTypeUrl";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("url")]
                public string Url { get; set; }
            }
        }
    }
}