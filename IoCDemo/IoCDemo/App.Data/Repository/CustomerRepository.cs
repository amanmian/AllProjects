using App.Data.EntityModels;
using App.Data.Infrastructure;

namespace App.Data.Repository
{

    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
    public interface ICustomerRepository: IRepository<Customer>
    {

    }
}
