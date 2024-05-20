using Compound_V.Application.User.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Compound_V_API.Controllers
{
    [ApiController]
    [Route("api/identity")]
    public class IdentityController(IMediator mediator)
        : ControllerBase
    {
        [HttpPost("userRole")]
        public async Task<IActionResult> AssignUserRole([FromBody]AssignUserRoleCommand command)
        {
            await mediator.Send(command);

            return NoContent();
        }

        [HttpPost("createRole")]
        public async Task<IActionResult> CreateRole([FromBody] CreateRoleCommand command)
        {
            await mediator.Send<CreateRoleCommand>(command);

            return Created();
        }
    }
}
