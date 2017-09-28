using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Webapi1.Models;
using Webapi1.Dtos;
using AutoMapper;

namespace Webapi1.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Member, MemberDto>();
            CreateMap<MemberDto, Member>();
        }
    }
}