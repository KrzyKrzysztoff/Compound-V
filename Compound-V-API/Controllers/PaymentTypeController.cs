using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Compound_V_API.Controllers
{

    [ApiController]
    [Route("api/paymentType")]
    public class PaymentTypeController(IMediator mediator)
        : ControllerBase
    {

    }

}
