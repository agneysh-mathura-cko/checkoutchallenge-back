using CKOChallenge2.Dtos;

namespace CKOChallenge2.Domain.Services;

public interface IPaymentGatewayService
{
    Task<PaymentGatewayResponse> TransactionProcess(PaymentGatewayRequest request);
}