using System;
using System.Data.Entity;
using TrackableWebApi.Entities.Shared.Net45;

// TODO: Alter DbContext class to implement this interface and change
// each DbSet property to IDbSet

namespace TrackableWebApi.Service.EF.Contexts
{
    public interface INorthwindContext
    {
        IDbSet<Category> Categories { get; set; }
        IDbSet<Customer> Customers { get; set; }
        IDbSet<Order> Orders { get; set; }
        IDbSet<OrderDetail> OrderDetails { get; set; }
        IDbSet<Product> Products { get; set; }
    }
}
