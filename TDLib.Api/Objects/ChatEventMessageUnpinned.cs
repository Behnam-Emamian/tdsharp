using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class ChatEventAction : Object
        {
            public class ChatEventMessageUnpinned : ChatEventAction
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "chatEventMessageUnpinned";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}