using Compound_V.Application.Teeth.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Compound_V_API.Controllers
{
    [ApiController]
    [Route("api/teeth")]
    public class TeethController(IMediator mediator)
        : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateTeeth(CreateTeethCommand createTeethCommand)
        {
            await mediator.Send(createTeethCommand);

            return Ok();
        }
    }
}
