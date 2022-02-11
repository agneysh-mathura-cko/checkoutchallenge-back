using CKOChallenge2.Domain;
using CKOChallenge2.Dtos;
using CKOChallenge2.Extensions;
using CKOChallenge2.Mappers;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CKOChallenge2.Controllers;

[ApiController]
[Route("[controller]")]
[EnableCors]
public class PaymentController : ControllerBase
{
    private readonly IPaymentService _paymentService;
    private readonly IRequestMapper _requestMapper;

    public PaymentController(IPaymentService paymentService, IRequestMapper requestMapper)
    {
        _paymentService = paymentService;
        _requestMapper = requestMapper;
    }

    // POST: api/Payments
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] GatewayRequest gatewayRequest)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var request = _requestMapper.MapToPaymentGatewayRequest(gatewayRequest);

        if (request.Source.Number == "0000000000000000")
        {
            return BadRequest("Invalid card number");
        }

        var result = await _paymentService.ProcessAsync(request);

        if (!result.Approved && !string.Equals(result.Status, "pending", StringComparison.OrdinalIgnoreCase))
        {
            return BadRequest("Not Approved");
        }
        
        return Ok(result);
    }
}