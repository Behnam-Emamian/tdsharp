using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class TestCallVectorString : Function<TestVectorString>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "testCallVectorString";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("x")]
            public string[] X { get; set; }
        }
    }
}