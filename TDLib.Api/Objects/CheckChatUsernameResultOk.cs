using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class CheckChatUsernameResult : Object
        {
            public class CheckChatUsernameResultOk : CheckChatUsernameResult
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "checkChatUsernameResultOk";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}