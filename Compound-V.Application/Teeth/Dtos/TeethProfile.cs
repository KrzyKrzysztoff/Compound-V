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

            CreateMap<CreateTeethCommand, Domain.Entities.Teeth>();

            //CreateMap<CreateTeethCommand, Domain.Entities.Teeth>()
            //    .ForMember(domain => domain.ToothType,
            //        command => command.MapFrom(src => new TeethType { Id = src.ToothTypeId }))
            //    .ForMember(domain => domain.Users,
            //        command => command.MapFrom(src => new Domain.Entities.User { Id = src.UserId }));
           
            //CreateMap<Domain.Entities.Teeth, CreateTeethCommand>()
            //    .ForMember(domain => domain.ToothTypeId,
            //        command => command.MapFrom(src => src.ToothType.Id))
            //    .ForMember(domain => domain.UserId,
            //        command => command.MapFrom(src => src.Users.Id));

        }
    }
}
