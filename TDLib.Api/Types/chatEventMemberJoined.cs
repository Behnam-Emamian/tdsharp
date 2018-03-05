using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ChatEventAction : Structure
    {

        public partial class chatEventMemberJoined : ChatEventAction
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "chatEventMemberJoined";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}