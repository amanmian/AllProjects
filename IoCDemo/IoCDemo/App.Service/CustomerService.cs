using App.Data.EntityModels;
using System.Collections.Generic;
using System;
using App.Data.Infrastructure;
using App.Data.Repository;

namespace App.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;

        public CustomerService(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return customerRepository.GetAll();
        }
    }

    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomers();
    }
}
