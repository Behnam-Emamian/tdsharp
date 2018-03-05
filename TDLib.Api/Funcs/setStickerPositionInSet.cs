using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class setStickerPositionInSet : Method<Ok>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "setStickerPositionInSet";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sticker")]
                public InputFile sticker_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("position")]
                public int? position_;

        }

    }

}