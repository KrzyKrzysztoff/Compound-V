using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Compound_V_API.Controllers
{

    [ApiController]
    [Route("api/payment")]
    public class PaymentController(IMediator mediator)
        : ControllerBase
    {

    }
}
