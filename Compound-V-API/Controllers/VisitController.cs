using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Compound_V_API.Controllers
{
    [ApiController]
    [Route("api/visit")]
    public class VisitController(IMediator mediator)
        : ControllerBase
    {

    }
}
