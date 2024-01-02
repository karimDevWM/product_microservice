using Microsoft.EntityFrameworkCore;
using productMicroservice.Data.Repository.Interface;
using productMicroservice.Model;

namespace productMicroservice.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DbContextClass _contextClass;
        public ProductRepository(DbContextClass contextClass)
        {
            _contextClass = contextClass;
        }

        public async Task<List<Product>> GetProductsAsync()
        {

            var elements = await _contextClass.Products.ToListAsync().ConfigureAwait(false);

            return elements;
        }

        public async Task<Product> GetProductByIdAsync(int productId)
        {
            var element = await _contextClass.Products.FirstOrDefaultAsync(product => product.ProductId == productId).ConfigureAwait(false);

            return element;
        }

        public async Task<Product> GetProductByNameAsync(string name)
        {
            var element = await _contextClass.Products.FirstOrDefaultAsync(product => product.ProductName == name).ConfigureAwait(false);

            return element;
        }

        public async Task<Product> CreateProductAsync(Product product)
        {
            var elementAdded = await _contextClass.Products.AddAsync(product).ConfigureAwait(false);

            await _contextClass.SaveChangesAsync().ConfigureAwait(false);

            return elementAdded.Entity;
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            var elementUpdated = _contextClass.Products.Update(product);

            await _contextClass.SaveChangesAsync().ConfigureAwait(false);

            return elementUpdated.Entity;
        }

        public async Task<Product> DeleteProductAsync(Product product)
        {
            var elementDeleted = _contextClass.Products.Remove(product);

            await _contextClass.SaveChangesAsync().ConfigureAwait(false);

            return elementDeleted.Entity;

        }
    }
}
