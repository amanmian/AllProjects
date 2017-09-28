using August_09_01_Full_application.Dtos;
using August_09_01_Full_application.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace August_09_01_Full_application.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentWebTable, StudentDto>();
            CreateMap<StudentDetailsWebTable, Dtos.StudentDetailsDto>();
            // Dto to Domain
            CreateMap<StudentDto, StudentWebTable>()
                .ForMember(c => c.Stud_id, opt => opt.Ignore());
        }
    }
}