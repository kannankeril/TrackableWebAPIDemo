using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using TrackableEntities.Patterns.EF6;
using TrackableWebApi.Entities.Shared.Net45;
using TrackableWebApi.Service.EF.Contexts;
using TrackableWebApi.Service.Persistence.Repositories;

namespace TrackableWebApi.Service.EF.Repositories
{
    // NOTE: ICustomerRepository will need to have been added to the Service.Persistence project

    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        // TODO: Match Database Context Interface type
        private readonly INorthwindContext _context;

        // TODO: Match Database Context Interface type
        public CustomerRepository(INorthwindContext context) :
            base(context as DbContext)
        {
            _context = context;
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            // TODO: Add Includes for related entities if needed
            IEnumerable<Customer> entities = await _context.Customers
                .ToListAsync();
            return entities;
        }

        public async Task<Customer> GetCustomer(string id)
        {
            // TODO: Add Includes for related entities if needed
            Customer entity = await _context.Customers
                 .SingleOrDefaultAsync(t => t.CustomerID == id);
            return entity;
        }

        public async Task<bool> DeleteCustomer(string id)
        {
            // TODO: Add Includes for related entities if needed
            Customer entity = await _context.Customers
                 .SingleOrDefaultAsync(t => t.CustomerID == id);
            if (entity == null) return false;
            ApplyDelete(entity);
            return true;
        }
    }
}
