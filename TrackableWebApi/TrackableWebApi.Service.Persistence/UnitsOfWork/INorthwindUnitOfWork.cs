using System;
using TrackableEntities.Patterns;
using TrackableWebApi.Service.Persistence.Repositories;

namespace TrackableWebApi.Service.Persistence.UnitsOfWork
{
    public interface INorthwindUnitOfWork : IUnitOfWork, IUnitOfWorkAsync
    {
        ICustomerRepository CustomerRepository { get; }
        IOrderRepository OrderRepository { get; }
    }
}
