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
    // NOTE: IOrderRepository will need to have been added to the Service.Persistence project

    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        // TODO: Match Database Context Interface type
        private readonly INorthwindContext _context;

        // TODO: Match Database Context Interface type
        public OrderRepository(INorthwindContext context) :
            base(context as DbContext)
        {
            _context = context;
        }

        public async Task<IEnumerable<Order>> GetOrders()
        {
            // TODO: Add Includes for related entities if needed
            IEnumerable<Order> entities = await _context.Orders
                .Include(e=> e.Customer)
                .Include("OrderDetails.Product")
                .ToListAsync();
            return entities;
        }

        public async Task<IEnumerable<Order>> GetOrders(string customerId)
        {
            IEnumerable<Order> entities = await _context.Orders
                .Include(e => e.Customer)
                .Include("OrderDetails.Product")
                .ToListAsync();
            return entities;
        }

        public async Task<Order> GetOrder(int id)
        {
            // TODO: Add Includes for related entities if needed
            Order entity = await _context.Orders
                .Include(e => e.Customer)
                .Include("OrderDetails.Product")
                 .SingleOrDefaultAsync(t => t.OrderID == id);
            return entity;
        }

        public async Task<bool> DeleteOrder(int id)
        {
            // TODO: Add Includes for related entities if needed
            Order entity = await _context.Orders
                .Include(e => e.OrderDetails)
                 .SingleOrDefaultAsync(t => t.OrderID == id);
            if (entity == null) return false;
            ApplyDelete(entity);
            return true;
        }
    }
}
