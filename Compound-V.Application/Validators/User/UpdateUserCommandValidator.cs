using Compound_V.Application.User.Command;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Validators.User
{
    public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
    {
        public UpdateUserCommandValidator()
        {
            RuleFor(c => c.Email).NotNull().MinimumLength(6);
            RuleFor(c => c.UserName).NotNull().MinimumLength(6);
        }
    }
}
