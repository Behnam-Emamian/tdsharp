using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class AuthorizationState : Structure
    {

        public partial class authorizationStateWaitPassword : AuthorizationState
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "authorizationStateWaitPassword";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("password_hint")]
                public string password_hint_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("has_recovery_email_address")]
                public bool? has_recovery_email_address_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("recovery_email_address_pattern")]
                public string recovery_email_address_pattern_;

        }

    }

}