using Compound_V.Application.TeethFile.Dtos;
using Compound_V.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.TeethFile.Query
{
    public class GetTeethFileByIdQuery : IRequest<TeethFileDto>
    {
        public GetTeethFileByIdQuery(string teethFileTypeId)
        {
            if (!Guid.TryParse(teethFileTypeId, out Guid parsedGuid))
            {
                throw new ArgumentException("Cannot parse string teethFileTypeId to Guid");
            }

            TeethFileId = parsedGuid;
        }
        public Guid TeethFileId { get; set; }
    }
}
