using App.Data.EntityModels;
using App.Service;
using System.Collections.Generic;
using System.Web.Http;

namespace App.API.Controllers
{
    public class CustomerApiController : ApiController
    {
        private readonly ICustomerService customerService;

        public CustomerApiController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            try
            {
                return customerService.GetAllCustomers();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
