using Microsoft.AspNetCore.Mvc;
using productMicroservice.Model;
using productMicroservice.Services.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace productMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;
        public ProductsController(IProductService _productService)
        {
            productService = _productService;
        }
        [HttpGet]
        public IEnumerable<Product> ProductList()
        {
            var productList = productService.GetProductList();
            return productList;
        }
        [HttpGet("{id}")]
        public Product GetProductById(int id)
        {
            return productService.GetProductById(id);
        }
        [HttpPost]
        public Product AddProduct(Product product)
        {
            return productService.AddProduct(product);
        }
        [HttpPut]
        public Product UpdateProduct(Product product)
        {
            return productService.UpdateProduct(product);
        }
        [HttpDelete("{id}")]
        public bool DeleteProduct(int id)
        {
            return productService.DeleteProduct(id);
        }
    }
}
