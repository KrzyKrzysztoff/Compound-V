using Compound_V.Application.Teeth.Dtos;
using Compound_V.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Teeth.Query
{
    public class GetTeethByIdQuery : IRequest<TeethDto>
    {
        public GetTeethByIdQuery(string teethId)
        {
            if(Guid.TryParse(teethId, out var parsedGuid)) 
            {
                throw new ArgumentException("Invalid GUID format", nameof(teethId));
            }
         
            this.TeethId = parsedGuid;
        }
        public Guid TeethId { get; set; }
    }
}
