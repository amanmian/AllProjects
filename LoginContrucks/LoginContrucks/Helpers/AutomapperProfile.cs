using LoginContrucks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginContrucks.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}