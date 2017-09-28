using AutoMapper;
using WebApplication51.Dtos;
using WebApplication51.Models;

namespace WebApplication51.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            CreateMap<Customer, CustomerDto>();
           
            CreateMap<CustomerDetail, CustomerDetailDto>();



            // Dto to Domain
         
            CreateMap<CustomerDto, Customer>()
              .ForMember(c => c.Id, opt => opt.Ignore());
           CreateMap<CustomerDetailDto, CustomerDetail>()
                  .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}