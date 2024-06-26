using Compound_V.Application.Teeth.Command;
using Compound_V.Application.Teeth.Query;
using Compound_V.Domain.Entities;
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
        public async Task<IActionResult> CreateTeeth(CreateTeethCommand createTeethCommand)
        {
            await mediator.Send(createTeethCommand);

            return Ok();
        }

        [HttpDelete("deleteTeeth")]
        public async Task<IActionResult> DeleteTeeth(DeleteTeethCommand deleteTeethCommand)
        {
            await mediator.Send(deleteTeethCommand);

            return Ok();
        }

        [HttpGet("getTeethById")]
        public async Task<IActionResult> GetTeethById(GetTeethByIdQuery getTeethByIdQuery)
        {
            var teeth = await mediator.Send(getTeethByIdQuery);

            return Ok(teeth);
        }

        [HttpPatch("updateTeeth")]
        public async Task<IActionResult> UpdateTeeth(UpdateTeethCommand updateTeethCommand)
        {
            await mediator.Send(updateTeethCommand);

            return Ok();
        }

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

        [HttpPatch]
        public async Task<IActionResult> UpdateTeethType(UpdateTeethTypeCommand updateTeethTypeCommand)
        {
            await mediator.Send(updateTeethTypeCommand);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTeethFile(CreateTeethFileCommand createTeethFileCommand)
        {
            await mediator.Send(createTeethFileCommand);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTeethFile(DeleteTeethFileCommand deleteTeethFileCommand)
        {
            await mediator.Send(deleteTeethFileCommand);

            return Ok();
        }

        [HttpGet]
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
