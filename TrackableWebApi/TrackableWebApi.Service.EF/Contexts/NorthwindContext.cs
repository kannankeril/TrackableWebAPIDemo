namespace TrackableWebApi.Service.EF.Contexts
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Entities.Shared.Net45;

    public partial class NorthwindContext : DbContext, INorthwindContext
    {
        static NorthwindContext()
        {
            Database.SetInitializer(new NullDatabaseInitializer<NorthwindContext>());
        }

        public NorthwindContext()
            : base("name=NorthwindConnection")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public IDbSet<Category> Categories { get; set; }
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Employee> Employees { get; set; }
        public IDbSet<OrderDetail> OrderDetails { get; set; }
        public IDbSet<Order> Orders { get; set; }
        public IDbSet<Product> Products { get; set; }
        public IDbSet<Region> Regions { get; set; }
        public IDbSet<Shipper> Shippers { get; set; }
        public IDbSet<Supplier> Suppliers { get; set; }
        public IDbSet<Territory> Territories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerID)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Employees1)
                .WithOptional(e => e.Employee1)
                .HasForeignKey(e => e.ReportsTo);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Territories)
                .WithMany(e => e.Employees)
                .Map(m => m.ToTable("EmployeeTerritories").MapLeftKey("EmployeeID").MapRightKey("TerritoryID"));

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.CustomerID)
                .IsFixedLength();

            modelBuilder.Entity<Order>()
                .Property(e => e.Freight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Region>()
                .Property(e => e.RegionDescription)
                .IsFixedLength();

            modelBuilder.Entity<Region>()
                .HasMany(e => e.Territories)
                .WithRequired(e => e.Region)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shipper>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Shipper)
                .HasForeignKey(e => e.ShipVia);

            modelBuilder.Entity<Territory>()
                .Property(e => e.TerritoryDescription)
                .IsFixedLength();

            ModelCreating(modelBuilder);
        }

        partial void ModelCreating(DbModelBuilder modelBuilder);
    }
}
