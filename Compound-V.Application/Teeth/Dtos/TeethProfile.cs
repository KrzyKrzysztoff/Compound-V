using AutoMapper;
using Compound_V.Application.Teeth.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Teeth.Dtos
{
    public class TeethProfile : Profile
    {
        public TeethProfile()
        {
            CreateMap<Domain.Entities.Teeth, CreateTeethCommand>();
        }
    }
}
