using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webapiproject.Models;
using AutoMapper;
using webapiproject.D;

namespace webapiproject.App_Start
{
    public class MappingProfile:Profile
    {



        public MappingProfile()
        {
            CreateMap<Student, StudentDto>();
            CreateMap<StudentDto, Student>();
        }
    }
}
