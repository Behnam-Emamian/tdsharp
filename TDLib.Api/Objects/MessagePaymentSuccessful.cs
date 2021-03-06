using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class MessageContent : Object
        {
            public class MessagePaymentSuccessful : MessageContent
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "messagePaymentSuccessful";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("invoice_message_id")]
                public long InvoiceMessageId { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("currency")]
                public string Currency { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("total_amount")]
                public long TotalAmount { get; set; }
            }
        }
    }
}