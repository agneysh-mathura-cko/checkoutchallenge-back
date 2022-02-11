using Newtonsoft.Json;

namespace CKOChallenge2.Dtos
{
    public class PaymentGatewayRequest
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "source")]
        public Source Source { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public string Amount { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currency")]
        public string Currency { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reference")]
        public string? Reference { get; set; }
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "success_url")]
        public string? SuccessUrl { get; set; }
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "failure_url")]
        public string? FailureUrl { get; set; }
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "purpose")]
        public string? Purpose { get; set; }
    }
}