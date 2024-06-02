using Compound_V.Application.Role.Command;
using Compound_V.Application.Role.Queries;
using Compound_V.Application.User.Command;
using Compound_V.Application.User.Query;
using Compound_V.Domain.Entities;
using Compound_V.Domain.Interfaces;
using Compound_V.Infrastructure.Services.Token;
using MediatR;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Compound_V_API.Controllers
{
    [ApiController]
    [Route("api/identity")]
    public class IdentityController(IMediator mediator)
        : ControllerBase
    {

        [HttpPost("userRole")]
        [Authorize(Roles = "admin")]
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
            var asd = User;
            var roles = await mediator.Send(new GetRolesQuery());

            return Ok(roles);
        }

        [HttpGet("user/{id}")]
        public async Task<IActionResult> GetUser([FromRoute] string id)
        {
            var role = await mediator.Send(new GetUserQuery(id));

            return Ok(role);
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetUsers()
        {
            var users = await mediator.Send(new GetUsersQuery());

            return Ok(users);
        }

        [HttpPost("RegisterUser")]
        public async Task<IActionResult> Register([FromBody] CreateUserCommand command)
        {
            var userDto = await mediator.Send(command);

            var authDto = await mediator.Send(new GenerateTokenCommand(userDto));

            return Ok(authDto);
        }

        [HttpPost("LoginUser")]
        public async Task<IActionResult> Login([FromBody] VerifyUserCredentialsQuery query )
        {
            var userDto = await mediator.Send(query);

            var authDto = await mediator.Send(new GenerateTokenCommand(userDto));

            return Ok(authDto);
        }
    }
}
