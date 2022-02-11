using CKOChallenge2.Domain.Services;
using CKOChallenge2.Dtos;

namespace CKOChallenge2.Mappers;

public class RequestMapper : IRequestMapper
{
    private IDecryptionService _decryptionService;
    
    public RequestMapper(IDecryptionService decryptionService)
    {
        _decryptionService = decryptionService ?? throw new ArgumentNullException(nameof(decryptionService));
    }
    public PaymentGatewayRequest MapToPaymentGatewayRequest(GatewayRequest gatewayRequest)
    {
        var paymentRequestSource = new Source
        {
            Type = gatewayRequest.Type,
        };


        if (string.Equals(gatewayRequest.Type, "card", StringComparison.OrdinalIgnoreCase))
        {
            if (!string.IsNullOrWhiteSpace(gatewayRequest.EncryptedCardNumber))
            {
                paymentRequestSource.Number = _decryptionService.DecryptCardNumber(gatewayRequest.EncryptedCardNumber);
            }
            
            paymentRequestSource.ExpiryMonth = gatewayRequest.CardExpiryMonth;
            paymentRequestSource.ExpiryYear = gatewayRequest.CardExpiryYear;
            paymentRequestSource.Cvv = gatewayRequest.Cvv;
        }
   

        var paymentRequest = new PaymentGatewayRequest
        {
            Source = paymentRequestSource,
            Amount = gatewayRequest.Amount,
            Currency = gatewayRequest.Currency,
            Reference = gatewayRequest?.OrderRef

        };

        if (string.Equals(gatewayRequest.Type, "giropay", StringComparison.OrdinalIgnoreCase))
        {
            paymentRequestSource.Purpose = gatewayRequest?.Purpose;
            paymentRequest.SuccessUrl = gatewayRequest?.SuccessUrl;
            paymentRequest.FailureUrl = gatewayRequest?.FailureUrl;
        }
        return paymentRequest;
    }
}