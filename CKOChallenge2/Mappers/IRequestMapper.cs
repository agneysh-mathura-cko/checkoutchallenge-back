using CKOChallenge2.Dtos;

namespace CKOChallenge2.Mappers;

public interface IRequestMapper
{
    PaymentGatewayRequest MapToPaymentGatewayRequest(GatewayRequest gatewayRequest);
}