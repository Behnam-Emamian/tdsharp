using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class ChatAction : Object
        {
            public class ChatActionRecordingVideo : ChatAction
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "chatActionRecordingVideo";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}