using Newtonsoft.Json;

namespace CKOChallenge2.Domain.Services.Communication
{
    public class BankResponse
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "action_id")]
        public string ActionId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public int Amount { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currency")]
        public string Currency { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "approved")]
        public bool Approved { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "auth_code")]
        public string AuthCode { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "eci")]
        public string Eci { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scheme_id")]
        public string SchemeId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "response_code")]
        public string ResponseCode { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "response_summary")]
        public string ResponseSummary { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "risk")]
        public Risk Risk { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "source")]
        public Source Source { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customer")]
        public Customer Customer { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "processed_on")]
        public DateTime ProcessedOn { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reference")]
        public string Reference { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "processing")]

        public Processing Processing { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "_links")]

        public Links Links { get; set; }
    }

    public class Risk
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "flagged")]
        public bool Flagged { get; set; }
    }

    public class Source
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expiry_month")]
        public int ExpiryMonth { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expiry_year")]
        public int ExpiryYear { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "last4")]
        public string Last4 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fingerprint")]

        public string Fingerprint { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bin")]

        public string Bin { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "avs_check")]

        public string AvsCheck { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cvv_check")]

        public string CvvCheck { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payouts")]

        public bool Payouts { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fast_funds")]
        public string FastFunds { get; set; }
    }


    public class Customer
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string Id { get; set; }
    }

    public class Processing
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "acquirer_transaction_id")]

        public string AcquirerTransactionId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "retrieval_reference_number")]

        public string RetrievalReferenceNumber { get; set; }
    }

    public class Self
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "href")]
        public string Href { get; set; }
    }

    public class Actions
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "href")]

        public string Href { get; set; }
    }

    public class Capture
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "href")]

        public string Href { get; set; }
    }

    public class Void
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "href")]

        public string Href { get; set; }
    }


    public class Links
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "self")]

        public Self Self { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actions")]

        public Actions Actions { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "capture")]

        public Capture Capture { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "void")]

        public Void @Void { get; set; }
    }
}