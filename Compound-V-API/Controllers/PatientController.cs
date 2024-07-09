using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Compound_V_API.Controllers
{
    [ApiController]
    [Route("api/patient")]
    public class PatientController(IMediator mediator)
        : ControllerBase
    {

    }
}
