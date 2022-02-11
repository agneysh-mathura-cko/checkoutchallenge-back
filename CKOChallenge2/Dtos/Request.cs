namespace CKOChallenge2.Dtos;

public class Request
{
    public string Type { get; set; }
    public string EncryptedCardNumber { get; set; }
    public int Cvv { get; set; }
    public string CardExpiryMonth { get; set; }
    public string CardExpiryYear { get; set; }
    public string OrderRef { get; set; }
    public double Amount { get; set; }
    public string Currency { get; set; }
}