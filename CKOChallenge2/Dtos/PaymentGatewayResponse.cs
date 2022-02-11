namespace CKOChallenge2.Dtos;

public class PaymentGatewayResponse
{
    public int Amount { get; set; }
    public string Currency { get; set; }
    public bool Approved { get; set; }
    public string Status { get; set; }
    public string AuthCode { get; set; }
    public string Eci { get; set; }
    public string SchemeId { get; set; }
    public string ResponseCode { get; set; }
    public string ResponseSummary { get; set; }
}