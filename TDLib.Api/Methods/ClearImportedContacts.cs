using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class ClearImportedContacts : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "clearImportedContacts";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

    }

}