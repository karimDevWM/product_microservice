﻿using productMicroservice.Model;

namespace productMicroservice.Data.Repository.Interface
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsAsync();

        Task<Product> GetProductByIdAsync(int productId);

        Task<Product> CreateProductAsync(Product product);

        Task<Product> UpdateProductAsync(Product product);

        Task<Product> DeleteProductAsync(Product product);
    }
}
