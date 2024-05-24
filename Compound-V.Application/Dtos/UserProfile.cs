using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Dtos
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        {
            CreateMap<Domain.Entities.User, UserDto>();
        }
    }
}
