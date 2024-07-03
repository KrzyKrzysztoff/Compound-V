using Compound_V.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Teeth.Command
{
    public class DeleteTeethCommand : IRequest
    {
        public DeleteTeethCommand(string teethId = default!)
        {
            if (!Guid.TryParse(teethId, out Guid parsedGuid))
            {
                throw new ArgumentException("Invalid GUID format", nameof(teethId));
            }

            this.TeethId = parsedGuid;
        }
        public Guid TeethId { get; set; }
    }
}
