using AutoMapper;
using Compound_V.Application.Teeth.Command;
using Compound_V.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Compound_V.Application.Teeth.Dtos
{
    public class TeethProfile : Profile
    {
        public TeethProfile()
        {
            CreateMap<TeethDto, Domain.Entities.Teeth>();
        }
    }
}
