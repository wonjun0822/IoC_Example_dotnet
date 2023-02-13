using IoC_Example.Repository;
using Microsoft.AspNetCore.Mvc;

namespace IoC_Example.Controllers;

[ApiController]
[Route("api")]
public class PayController : ControllerBase
{
    private readonly IEnumerable<IPayService> _payService;

    public PayController(IEnumerable<IPayService> payService) {
        _payService = payService;
    }

    [HttpGet]
    public string Credit(string creditType) {
        return _payService.FirstOrDefault(x => x.creditType == creditType)?.Credit()!;
    }
}