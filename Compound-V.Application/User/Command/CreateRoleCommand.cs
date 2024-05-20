using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.User.Command
{
    public class CreateRoleCommand :IRequest
    {
        public string Name { get; set; } = default!;
    }
}
