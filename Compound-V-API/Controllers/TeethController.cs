using Compound_V.Application.Teeth.Command.Create;
using Compound_V.Application.Teeth.Command.Delete;
using Compound_V.Application.Teeth.Command.Update;
using Compound_V.Application.Teeth.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Compound_V_API.Controllers
{
    [ApiController]
    [Route("api/teeth")]
    public class TeethController(IMediator mediator)
        : ControllerBase
    {
        [HttpPost("createTeeth")]
        public async Task<IActionResult> CreateTeeth([FromBody] CreateTeethCommand createTeethCommand)
        {
            await mediator.Send(createTeethCommand);

            return Ok();
        }

        [HttpDelete("deleteTeeth/{teethId}")]
        public async Task<IActionResult> DeleteTeeth([FromRoute] string teethId)
        {
            await mediator.Send(new DeleteTeethCommand(teethId));

            return Ok();
        }

        [HttpGet("getTeethById/{teethId}")]
        public async Task<IActionResult> GetTeethById([FromRoute] string teethId)
        {
            var teeth = await mediator.Send(new GetTeethByIdQuery(teethId));

            return Ok(teeth);
        }

        [HttpPatch("updateTeeth")]
        public async Task<IActionResult> UpdateTeeth([FromBody] UpdateTeethCommand updateTeethCommand)
        {
            await mediator.Send(updateTeethCommand);

            return Ok();
        }
    }
}
