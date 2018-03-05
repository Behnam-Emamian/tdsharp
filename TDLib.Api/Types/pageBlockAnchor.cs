using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class PageBlock : Structure
    {

        public partial class pageBlockAnchor : PageBlock
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "pageBlockAnchor";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("name")]
                public string name_;

        }

    }

}