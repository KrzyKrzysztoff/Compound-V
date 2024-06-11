using Compound_V.Application.User.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.User.Query
{
    public class VerifyUserCredentialsQuery : IRequest<UserDto>
    {
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}
