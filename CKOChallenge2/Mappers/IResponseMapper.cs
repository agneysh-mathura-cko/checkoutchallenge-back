using CKOChallenge2.Domain.Services.Communication;
using CKOChallenge2.Dtos;

namespace CKOChallenge2.Mappers;

public interface IResponseMapper
{
    PaymentGatewayResponse MapToPaymentGatewayResponse (BankResponse bankResponse);
}