using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class PhotoSize : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "photoSize";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("photo")]
            public File Photo { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("width")]
            public int Width { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("height")]
            public int Height { get; set; }
        }
    }
}