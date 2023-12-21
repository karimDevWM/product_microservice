using NUnit.Framework;
using productMicroservice.Data;
using productMicroservice.Model;
using productMicroservice.Tests.Common.ScenarioDatas;

namespace productMicroservice.Tests.unitTest
{
    public class ProductUnitTest : Common.TestBase
    {
        private DbContextClass _dbContextClass;

        [SetUp]
        public void Setup()
        {
            SetupTest();

            DbContextClass? dbContextClass = _serviceProvider.GetService<DbContextClass>();
            _dbContextClass = dbContextClass!;

            _dbContextClass.CreateProduct();
        }

        [TearDown]
        public void Teardown()
        {
            CleanTest();
        }

        [Test]
        public async Task CreateProduct()
        {
            // Arrange
            var product = new Product()
            {
                ProductId = 2,
                ProductName = "Table en crystal",
                ProductDescription = "Table basse rectangulaire en crystal, idéal pour le salon",
                ProductPrice = 500,
                ProductStock = 1
            };

            // Act
            var productToAdd = await _dbContextClass.Products.AddAsync(product).ConfigureAwait(false);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(productToAdd, Is.Not.Null);
                Assert.That(product.ProductName, Is.EqualTo("Table en crystal"));
            });
        }
    }
}
