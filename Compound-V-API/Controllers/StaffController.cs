using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Compound_V_API.Controllers
{
    [ApiController]
    [Route("api/staff")]
    public class StaffController(IMediator mediator)
        : ControllerBase
    {

    }
}
