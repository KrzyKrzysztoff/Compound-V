using Compound_V.Application.TeethType.Command.Create;
using Compound_V.Application.TeethType.Command.Delete;
using Compound_V.Application.TeethType.Command.Update;
using Compound_V.Application.TeethType.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Compound_V_API.Controllers
{
    [ApiController]
    [Route("api/teethType")]
    public class TeethTypeController(IMediator mediator)
      : ControllerBase
    {
        [HttpPost("createTeethType")]
        public async Task<IActionResult> CreateTeethType([FromBody] CreateTeethTypeCommand createTeethTypeCommand)
        {
            await mediator.Send(createTeethTypeCommand);

            return Ok();
        }

        [HttpDelete("deleteTeethType/{teethTypeId}")]
        public async Task<IActionResult> DeleteTeethType([FromRoute] string teethTypeId)
        {
            await mediator.Send(new DeleteTeethTypeCommand(teethTypeId));

            return Ok();
        }

        [HttpGet("getTeethTypeById/{teethTypeId}")]
        public async Task<IActionResult> GetTeethTypeById([FromRoute] string teethTypeId)
        {
            var teeth = await mediator.Send(new GetTeethTypeByIdQuery(teethTypeId));

            return Ok(teeth);
        }

        [HttpPatch("updateTeethType")]
        public async Task<IActionResult> UpdateTeethType([FromBody] UpdateTeethTypeCommand updateTeethTypeCommand)
        {
            await mediator.Send(updateTeethTypeCommand);

            return Ok();
        }
    }
}
