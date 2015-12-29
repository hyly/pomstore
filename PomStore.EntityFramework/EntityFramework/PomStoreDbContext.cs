using System.Data.Common;
using Abp.Zero.EntityFramework;
using PomStore.Authorization.Roles;
using PomStore.MultiTenancy;
using PomStore.Users;
using System.Data.Entity;
using PomStore.Entities;

namespace PomStore.EntityFramework
{
    public class PomStoreDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public virtual IDbSet<Customer> Customers { get; set; }
        public virtual IDbSet<Product> Products { get; set; }
        public virtual IDbSet<Order> Orders { get; set; }
        public virtual IDbSet<OrderItem> OrderItems { get; set; }
        public virtual IDbSet<ReOrder> ReOrders { get; set; }
        public virtual IDbSet<ReOrderItem> ReOrderItems { get; set; }
        public virtual IDbSet<Staff> Staffs { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public PomStoreDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in PomStoreDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of PomStoreDbContext since ABP automatically handles it.
         */
        public PomStoreDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public PomStoreDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
