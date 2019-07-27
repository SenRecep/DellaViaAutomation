namespace DellaViaAutomation.Dal.ComplexType.EntityFramework
{
    using DellaViaAutomation.Entities.ComplexType;
    using DellaViaAutomation.Entities.Concreate;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;


    public class DellaViaAutomationDbModel : DbContext
    {

        public DellaViaAutomationDbModel()
            : base(@"Data Source=DESKTOP-F562OK2\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DellaViaAutomationDb")
        {
            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            if (type == null)
                throw new Exception("System.Data.Entity.SqlServer.SqlProviderServices Exception!! {DellaViaAutomation.Dal.DellaViaAutomationDbModel}");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<PostalCode> PostalCodes { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<OrderPayment> OrderPayments { get; set; }
    }
}