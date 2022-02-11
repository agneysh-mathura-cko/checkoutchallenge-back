using CKOChallenge2.Domain;
using CKOChallenge2.Domain.Services;
using CKOChallenge2.Domain.Services.Communication;
using CKOChallenge2.Dtos;

namespace CKOChallenge2.Services
{
    public class PaymentService : IPaymentService
    {
        private IPaymentGatewayService _paymentGatewayService;

        public PaymentService(IPaymentGatewayService paymentGatewayService)
        {
            _paymentGatewayService =
                paymentGatewayService ?? throw new ArgumentNullException(nameof(paymentGatewayService));
        }

        public async Task<PaymentGatewayResponse> ProcessAsync(PaymentGatewayRequest paymentGatewayRequest)
        {
            var result = await _paymentGatewayService.TransactionProcess(paymentGatewayRequest);

            return result;
        }
    }
}