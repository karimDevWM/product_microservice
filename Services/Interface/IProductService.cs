using productMicroservice.Model;

namespace productMicroservice.Services.Interface
{
    public interface IProductService
    {
        Task<List<Product>> GetProductList();
        Task<Product> GetProductByIdAsync(int productId);
        Task<Product> GetProductByNameAsync(string name);
        Task<Product> CreateProductAsync(Product product);
        Task<Product> UpdateProductAsync(Product product, int productId);
        Task<Product> DeleteProductAsync(int productId);
    }
}
