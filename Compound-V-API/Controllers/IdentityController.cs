using Compound_V.Application.Role.Command;
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

        [HttpPost("createUser")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand command)
        {
            await mediator.Send(command);

            return NoContent();
        }

        [HttpPost("unAssignUserRole")]
        public async Task<IActionResult> UnAssignUserRole([FromBody] UnAssignUserRoleCommand command)
        {
            await mediator.Send(command);

            return NoContent();
        }

        [HttpPost("role")]
        public async Task<IActionResult> CreateRole([FromBody] CreateRoleCommand command)
        {
            await mediator.Send<CreateRoleCommand>(command);

            return Created();
        }

        [HttpDelete("role")]
        public async Task<IActionResult> DeleteRole([FromBody] DeleteRoleCommand command)
        {
            await mediator.Send<DeleteRoleCommand>(command);

            return NoContent();
        }

        [HttpPatch("role")]
        public async Task<IActionResult> UpdateRole([FromBody] UpdateRoleCommand command)
        {
            await mediator.Send<UpdateRoleCommand>(command);

            return NoContent();
        }

        [HttpDelete("user")]
        public async Task<IActionResult> deleteUser([FromBody] DeleteUserCommand command)
        {
            await mediator.Send<DeleteUserCommand>(command);

            return NoContent();
        }
    }
}
