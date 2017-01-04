using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading;
using System.Threading.Tasks;
using TrackableEntities.Patterns.EF6;
using TrackableWebApi.Service.EF.Contexts;
using TrackableWebApi.Service.Persistence.Exceptions;
using TrackableWebApi.Service.Persistence.Repositories;
using TrackableWebApi.Service.Persistence.UnitsOfWork;

namespace TrackableWebApi.Service.EF.UnitsOfWork
{
    // Implements INorthwindUnitOfWork in the Persistence project
    public class NorthwindUnitOfWork : UnitOfWork, INorthwindUnitOfWork
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IOrderRepository _orderRepository;

        public NorthwindUnitOfWork(INorthwindContext context
                                                    , ICustomerRepository customerRepository
                                                    , IOrderRepository orderRepository) :
            base(context as DbContext)
        {
            _customerRepository = customerRepository;
            _orderRepository = orderRepository;
        }

        public ICustomerRepository CustomerRepository
        {
            get { return _customerRepository; }
        }

        public IOrderRepository OrderRepository
        {
            get { return _orderRepository; }
        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbUpdateConcurrencyException concurrencyException)
            {
                throw new UpdateConcurrencyException(concurrencyException.Message,
                    concurrencyException);
            }
            catch (DbUpdateException updateException)
            {
                throw new UpdateException(updateException.Message,
                    updateException);
            }
        }

        public override Task<int> SaveChangesAsync()
        {
            return SaveChangesAsync(CancellationToken.None);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            try
            {
                return base.SaveChangesAsync(cancellationToken);
            }
            catch (DbUpdateConcurrencyException concurrencyException)
            {
                throw new UpdateConcurrencyException(concurrencyException.Message,
                    concurrencyException);
            }
            catch (DbUpdateException updateException)
            {
                throw new UpdateException(updateException.Message,
                    updateException);
            }
        }
    }
}
