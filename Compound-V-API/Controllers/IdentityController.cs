using Compound_V.Application.Role.Command;
using Compound_V.Application.Role.Queries;
using Compound_V.Application.User.Command;
using Compound_V.Application.User.Query;
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

        [HttpPatch("updateUser")]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserCommand command)
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
        public async Task<IActionResult> DeleteUser([FromBody] DeleteUserCommand command)
        {
            await mediator.Send<DeleteUserCommand>(command);

            return NoContent();
        }


        [HttpGet("role/{id}")]
        public async Task<IActionResult> Role([FromRoute] string id)
        {
            var role = await mediator.Send(new GetRoleQuery(id));

            return Ok(role);
        }

        [HttpGet("roles")]
        public async Task<IActionResult> Roles()
        {
            var roles = await mediator.Send(new GetRolesQuery());

            return Ok(roles);
        }

        [HttpGet("user/{id}")]
        public async Task<IActionResult> User([FromRoute] string id)
        {
            var role = await mediator.Send(new GetUserQuery(id));

            return Ok(role);
        }
    }
}
