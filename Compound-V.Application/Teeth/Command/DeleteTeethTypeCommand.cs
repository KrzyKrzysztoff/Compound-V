using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Teeth.Command
{
    public class DeleteTeethTypeCommand : IRequest
    {
        public DeleteTeethTypeCommand(string teethTypeId = default!)
        {
            if (!Guid.TryParse(teethTypeId, out Guid parsedGuid))
            {
                throw new ArgumentException("Invalid GUID format", nameof(teethTypeId));
            }

            this.TeethTypeId = parsedGuid;
        }
        public Guid TeethTypeId { get; set; }
    }
}
