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
        public async Task<IActionResult> CreateTeethFile(CreateTeethFileCommand createTeethFileCommand)
        {
            await mediator.Send(createTeethFileCommand);

            return Ok();
        }

        [HttpDelete("deleteTeethFile")]
        public async Task<IActionResult> DeleteTeethFile(DeleteTeethFileCommand deleteTeethFileCommand)
        {
            await mediator.Send(deleteTeethFileCommand);

            return Ok();
        }

        [HttpGet("getTeethFileById")]
        public async Task<IActionResult> GetTeethFileById(GetTeethFileByIdQuery getTeethFileByIdQuery)
        {
            var teeth = await mediator.Send(getTeethFileByIdQuery);

            return Ok(teeth);
        }

        [HttpPatch("updateTeethFile")]
        public async Task<IActionResult> UpdateTeethFile(UpdateTeethFileCommand updateTeethFileCommand)
        {
            await mediator.Send(updateTeethFileCommand);

            return Ok();
        }
    }
}
