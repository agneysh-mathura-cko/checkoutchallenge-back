using CKOChallenge2.Domain.Services.Communication;
using CKOChallenge2.Dtos;

namespace CKOChallenge2.Domain;

public interface IPaymentService
{
    Task<PaymentGatewayResponse> ProcessAsync(PaymentGatewayRequest paymentGatewayRequest);
}