namespace CKOChallenge2.Dtos;

public class GatewayRequest
{
    public string Type { get; set; }
    public string? EncryptedCardNumber { get; set; }
    public string? Cvv { get; set; }
    public string? CardExpiryMonth { get; set; }
    public string? CardExpiryYear { get; set; }
    public string? OrderRef { get; set; }
    public string Amount { get; set; }
    public string Currency { get; set; }  
    public string? Purpose { get; set; }  
    public string? SuccessUrl { get; set; }  
    public string? FailureUrl { get; set; }  
}