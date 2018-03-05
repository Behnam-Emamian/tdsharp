using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ShippingAddress : Structure
    {

        public partial class shippingAddress : ShippingAddress
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "shippingAddress";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("country_code")]
                public string country_code_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("state")]
                public string state_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("city")]
                public string city_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("street_line1")]
                public string street_line1_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("street_line2")]
                public string street_line2_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("postal_code")]
                public string postal_code_;

        }

    }

}