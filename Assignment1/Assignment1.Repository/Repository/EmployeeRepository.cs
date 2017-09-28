using Assignment1.Repository.Entity;
using Assignment1.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Repository.Repository
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
    public interface IEmployeeRepository : IRepository<Employee>
    {

    }
}
