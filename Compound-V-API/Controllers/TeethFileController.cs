using Compound_V.Application.TeethFile.Command.Create;
using Compound_V.Application.TeethFile.Command.Delete;
using Compound_V.Application.TeethFile.Command.Update;
using Compound_V.Application.TeethFile.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Compound_V_API.Controllers
{
    [ApiController]
    [Route("api/teethFile")]
    public class TeethFileController(IMediator mediator)
      : ControllerBase
    {
        [HttpPost("createTeethFile")]
        public async Task<IActionResult> CreateTeethFile([FromBody] CreateTeethFileCommand createTeethFileCommand)
        {
            await mediator.Send(createTeethFileCommand);

            return Ok();
        }

        [HttpDelete("deleteTeethFile/{teethTypeId}")]
        public async Task<IActionResult> DeleteTeethFile([FromRoute] string teethFileTypeId)
        {
            await mediator.Send(new DeleteTeethFileCommand(teethFileTypeId));

            return Ok();
        }

        [HttpGet("getTeethFileById/{teethTypeId}")]
        public async Task<IActionResult> GetTeethFileById([FromRoute] string teethFileTypeId)
        {
            var teeth = await mediator.Send(new GetTeethFileByIdQuery(teethFileTypeId));

            return Ok(teeth);
        }

        [HttpPatch("updateTeethFile")]
        public async Task<IActionResult> UpdateTeethFile([FromBody] UpdateTeethFileCommand updateTeethFileCommand)
        {
            await mediator.Send(updateTeethFileCommand);

            return Ok();
        }
    }
}
