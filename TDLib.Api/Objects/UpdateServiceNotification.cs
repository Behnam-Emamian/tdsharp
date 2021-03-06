using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class Update : Object
        {
            public class UpdateServiceNotification : Update
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "updateServiceNotification";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("type")]
                public string Type { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("content")]
                public MessageContent Content { get; set; }
            }
        }
    }
}