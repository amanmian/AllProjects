using Assignment4.Repository.Entity;
using Assignment4.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Repository.Repository
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
