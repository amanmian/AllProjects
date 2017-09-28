using Assignment1.Repository.Entity;
using Assignment1.Repository.Infrastructure;
using Assignment1.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IUnitOfWork unitOfWork;

        public EmployeeService(IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork)
        {
            this.employeeRepository = employeeRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Employee> GetAllCustomers()
        {
            return employeeRepository.GetAll();
        }
    }

    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllCustomers();
    }
}
