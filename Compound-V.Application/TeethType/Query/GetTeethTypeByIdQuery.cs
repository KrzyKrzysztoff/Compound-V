using Compound_V.Application.TeethType.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.TeethType.Query
{
    public class GetTeethTypeByIdQuery : IRequest<TeethTypeDto>
    {
        public GetTeethTypeByIdQuery(string teethTypeId)
        {
            if (!Guid.TryParse(teethTypeId, out Guid parsedGuid))
            {
                throw new ArgumentException("Cannot parse string teethTypeId to Guid");
            }

            TeethTypeId = parsedGuid;
        }
        public Guid TeethTypeId { get; set; }
    }
}
