using Newtonsoft.Json;

namespace CKOChallenge2.Dtos;

public class Source
{
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type")]
    public string Type  { get; set; }    
    
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "number")]
    public string Number  { get; set; }

    [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expiry_month")]
    public string? ExpiryMonth  { get; set; }
    
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expiry_year")]
    public string? ExpiryYear  { get; set; }
    
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cvv")]
    public string? Cvv  { get; set; }
    
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "purpose")]
    public string? Purpose  { get; set; }
}