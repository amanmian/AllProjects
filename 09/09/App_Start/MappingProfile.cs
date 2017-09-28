using _09.Dto;
using _09.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _09.App_Start
{
    public class MappingProfile:Profile
    {
       
     public MappingProfile()
        {
            CreateMap<Student1, StudentDto>();
            CreateMap<StudentDetalis1, StudentsDetailsDto>();

            CreateMap<StudentDto, Student1>().ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}