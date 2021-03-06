using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class ProxyType : Object
        {
            public class ProxyTypeMtproto : ProxyType
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "proxyTypeMtproto";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("secret")]
                public string Secret { get; set; }
            }
        }
    }
}