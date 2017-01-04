using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrackableEntities.Patterns;
using TrackableWebApi.Entities.Shared.Net45;

namespace TrackableWebApi.Service.Persistence.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>, IRepositoryAsync<Customer>
    {
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer> GetCustomer(string id);
        Task<bool> DeleteCustomer(string id);
    }
}
