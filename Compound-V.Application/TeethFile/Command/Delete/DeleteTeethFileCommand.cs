using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.TeethFile.Command.Delete
{
    public class DeleteTeethFileCommand : IRequest
    {
        public DeleteTeethFileCommand(string teethFileTypeId)
        {
            if (!Guid.TryParse(teethFileTypeId, out Guid parsedGuid))
            {
                throw new ArgumentException("Cannot parse string teethTypeId to Guid");
            }

            TeethFileId = parsedGuid;
        }
        public Guid TeethFileId { get; set; }
    }
}
