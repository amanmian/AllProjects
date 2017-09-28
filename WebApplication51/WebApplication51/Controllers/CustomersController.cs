using AutoMapper;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using WebApplication51.Dtos;
using WebApplication51.Models;

namespace WebApplication51.Controllers
{
    public class CustomersController : ApiController
    {
        private Context  _context;

        public CustomersController()
        {
            _context = new Context();
          
        }

        // GET /api/customers
        public IHttpActionResult GetCustomers(string query = null)
        {
            
            var customersQuery = _context.customers
                .Include(c => c.customerdetails);

            if (!String.IsNullOrWhiteSpace(query))
                customersQuery = customersQuery.Where(c => c.FirstName.Contains(query));

            var customerDtos = customersQuery
                .ToList()
                .Select(Mapper.Map<Customer, CustomerDto>);

            return Ok(customerDtos);
        }


        // GET /api/customers/1
        public IHttpActionResult GetCustomer(int id)
        {
            var stud = _context.customers.SingleOrDefault(c => c.Id == id);
                          
            if (stud == null)
                return NotFound();

            return Ok(Mapper.Map<Customer, CustomerDto>(stud));
        }

        // POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;
            return Created(new Uri(Request.RequestUri + "/" + customer.Id), customerDto);
        }

        // PUT /api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var cust = _context.customers.SingleOrDefault(c => c.Id == id);

            if (cust == null)
                return NotFound();

            Mapper.Map(customerDto, cust);

            _context.SaveChanges();

            return Ok();
        }

        // DELETE /api/customers/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var cust = _context.customers.SingleOrDefault(c => c.Id == id);

            if (cust == null)
                return NotFound();

            _context.customers.Remove(cust);
            _context.SaveChanges();

            return Ok();
        }
    }
}
