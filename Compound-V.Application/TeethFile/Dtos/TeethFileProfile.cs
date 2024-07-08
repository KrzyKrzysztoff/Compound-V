using AutoMapper;
using Compound_V.Application.Teeth.Dtos;
using Compound_V.Application.TeethType.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.TeethFile.Dtos
{
    public class TeethFileProfile : Profile
    {
        public TeethFileProfile()
        {
            CreateMap<TeethFileDto, Domain.Entities.File>();
        }
    }
}
