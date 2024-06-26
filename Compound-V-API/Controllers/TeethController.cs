using Compound_V.Application.Teeth.Command;
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
        [HttpPost]
        public async Task<IActionResult> CreateTeeth(CreateTeethCommand createTeethCommand)
        {
            await mediator.Send(createTeethCommand);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTeeth(DeleteTeethCommand deleteTeethCommand)
        {
            await mediator.Send(deleteTeethCommand);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetTeethById(GetTeethByIdQuery getTeethByIdQuery)
        {
            var teeth = await mediator.Send(getTeethByIdQuery);

            return Ok(teeth);
        }

        [HttpPatch]
        public async Task<IActionResult> UpdateTeeth(UpdateTeethCommand updateTeethCommand)
        {
            await mediator.Send(updateTeethCommand);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTeethType(CreateTeethTypeCommand createTeethTypeCommand)
        {
            await mediator.Send(createTeethTypeCommand);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTeethType(DeleteTeethTypeCommand deleteTeethTypeCommand)
        {
            await mediator.Send(deleteTeethTypeCommand);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetTeethTypeById(GetTeethTypeByIdQuery getTeethTypeByIdQuery)
        {
            var teeth = await mediator.Send(getTeethTypeByIdQuery);

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

        [HttpPatch]
        public async Task<IActionResult> UpdateTeethFile(UpdateTeethFileCommand updateTeethFileCommand)
        {
            await mediator.Send(updateTeethFileCommand);

            return Ok();
        }
    }
}
