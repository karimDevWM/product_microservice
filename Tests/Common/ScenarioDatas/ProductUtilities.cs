using productMicroservice.Data;
using productMicroservice.Model;

namespace productMicroservice.Tests.Common.ScenarioDatas
{
    public static class ProductUtilities
    {
        public static void CreateProduct(this DbContextClass dbContextClass)
        {
            var product = new Product
            {
                ProductId = 1,
                ProductName = "cendrier en argent",
                ProductDescription = "cendrier en argent, sculpté",
                ProductPrice = 200,
                ProductStock = 1
            };

            dbContextClass.Products.Add(product);
            dbContextClass.SaveChanges();
        }

        public static void CreateProducts(this DbContextClass dbContextClass)
        {
            var product1 = new Product
            {
                ProductId = 1,
                ProductName = "lustrier diamant",
                ProductDescription = "lustrier en diamant pour salon",
                ProductPrice = 800,
                ProductStock = 1
            };

            var product2 = new Product
            {
                ProductId = 2,
                ProductName = "horloge en or",
                ProductDescription = "horloge en or pour salon",
                ProductPrice = 600,
                ProductStock = 1
            };

            dbContextClass.Products.AddRange(product1, product2);
            dbContextClass.SaveChanges();
        }
    }
}
