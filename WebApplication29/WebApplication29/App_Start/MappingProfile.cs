using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication29.Dto;
using WebApplication29.Models;

namespace WebApplication29.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
              CreateMap<Studentviewmodel, StudentDto>();
               CreateMap<StudentDto, Studentviewmodel>();
        }
    }
}