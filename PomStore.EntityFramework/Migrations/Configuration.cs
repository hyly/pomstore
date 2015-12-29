using System.Data.Entity.Migrations;
using PomStore.Migrations.SeedData;

namespace PomStore.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<PomStore.EntityFramework.PomStoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PomStore";
        }

        protected override void Seed(PomStore.EntityFramework.PomStoreDbContext context)
        {
            new InitialDataBuilder(context).Build();
            context.Products.Add(new Entities.Product
            {
                Name = "Hộp phở bò phố cổ",
                Sku = "SP000001",
                SalesPrice = 10000,
                OrginalPrice=8000,
                
            });
            context.Products.Add(new Entities.Product
            {
                Name = "Thịt bò khô 30g",
                Sku = "SP000002",
                SalesPrice = 10000,
                OrginalPrice = 8000,

            });
            context.Products.Add(new Entities.Product
            {
                Name = "Rượu men 500ml",
                Sku = "SP000003",
                SalesPrice = 10000,
                OrginalPrice = 8000,

            });
            context.Products.Add(new Entities.Product
            {
                Name = "Rượu Vooka 750ml",
                Sku = "SP000004",
                SalesPrice = 10000,
                OrginalPrice = 8000,

            });
            context.Products.Add(new Entities.Product
            {
                Name = "Kẹo dynamite sôcola",
                Sku = "SP000005",
                SalesPrice = 10000,
                OrginalPrice = 8000,

            });
            context.SaveChanges();
        }
    }
}
