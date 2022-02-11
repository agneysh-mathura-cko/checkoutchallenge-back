using System.Text;
using CKOChallenge2.Domain.Services;
using CKOChallenge2.Domain.Services.Communication;
using CKOChallenge2.Dtos;
using CKOChallenge2.Mappers;
using Newtonsoft.Json;

namespace CKOChallenge2.Services;

public class PaymentGatewayService : IPaymentGatewayService
{
    private IResponseMapper _responseMapper;
    
    public PaymentGatewayService(IResponseMapper responseMapper)
    {
        _responseMapper = responseMapper ?? throw new ArgumentNullException(nameof(responseMapper));
    }
    
    public async Task<PaymentGatewayResponse> TransactionProcess(PaymentGatewayRequest request)
    {
        var client = new HttpClient();
        
        var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, "https://api.sandbox.checkout.com/payments");
        httpRequestMessage.Content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

        httpRequestMessage.Headers.Add("Authorization","sk_test_0b9b5db6-f223-49d0-b68f-f6643dd4f808");
            
        var response =
            await client.SendAsync(httpRequestMessage);

        var responseString = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<BankResponse>(responseString);

        var responsePayment = _responseMapper.MapToPaymentGatewayResponse(result);

        return responsePayment;
    }
}