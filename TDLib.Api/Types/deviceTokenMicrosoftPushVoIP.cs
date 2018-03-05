using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class DeviceToken : Structure
    {

        public partial class deviceTokenMicrosoftPushVoIP : DeviceToken
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "deviceTokenMicrosoftPushVoIP";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("channel_uri")]
                public string channel_uri_;

        }

    }

}