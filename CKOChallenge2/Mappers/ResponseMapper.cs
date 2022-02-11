using CKOChallenge2.Domain.Services.Communication;
using CKOChallenge2.Dtos;

namespace CKOChallenge2.Mappers;

public class ResponseMapper : IResponseMapper
{
    public PaymentGatewayResponse MapToPaymentGatewayResponse(BankResponse bankResponse)
    {
        var paymentGatewayResponse = new PaymentGatewayResponse();

        paymentGatewayResponse.Amount = bankResponse.Amount;
        paymentGatewayResponse.Approved = bankResponse.Approved;
        paymentGatewayResponse.Currency = bankResponse.Currency;
        paymentGatewayResponse.Eci = bankResponse.Eci;
        paymentGatewayResponse.ResponseCode = bankResponse.ResponseCode;
        paymentGatewayResponse.ResponseSummary = bankResponse.ResponseSummary;
        paymentGatewayResponse.Status = bankResponse.Status;
        paymentGatewayResponse.AuthCode = bankResponse.AuthCode;
        paymentGatewayResponse.SchemeId = bankResponse.SchemeId;

        return paymentGatewayResponse;
    }
}