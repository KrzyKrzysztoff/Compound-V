﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Teeth.Command
{
    public class DeleteTeethTypeCommand : IRequest
    {
        public Guid TeethTypeId { get; set; }
    }
}
