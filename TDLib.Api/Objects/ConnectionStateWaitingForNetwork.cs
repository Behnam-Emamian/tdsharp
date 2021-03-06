using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class ConnectionState : Object
        {
            public class ConnectionStateWaitingForNetwork : ConnectionState
            {
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "connectionStateWaitingForNetwork";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}