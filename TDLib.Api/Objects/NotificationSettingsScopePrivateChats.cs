using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class NotificationSettingsScope : Object
        {
            public class NotificationSettingsScopePrivateChats : NotificationSettingsScope
            {
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "notificationSettingsScopePrivateChats";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}