using AutoMapper;
using Compound_V.Application.Teeth.Dtos;
using Compound_V.Application.TeethFile.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.TeethType.Dtos
{
    public class TeethTypeProfile : Profile
    {
        public TeethTypeProfile()
        {
            CreateMap<TeethTypeDto, Domain.Entities.TeethType>();

            CreateMap<Domain.Entities.TeethType, TeethTypeDto>();
        }
    }
}
