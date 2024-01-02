using Microsoft.AspNetCore.Mvc;
using productMicroservice.Model;
using productMicroservice.Services.Interface;

// For more informations on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace productMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<ActionResult> ProductList()
        {
            try
            {
                var products = await _productService.GetProductList();

                return Ok(products);
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    Error = ex.Message,
                });
            }

        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetProductByIdAsync(int productId)
        {
            var product = await _productService.GetProductByIdAsync(productId);
            return Ok(product);
        }
        [HttpPost]
        public async Task<ActionResult> CreateProductAsync(Product product)
        {
            try
            {
                var productAdded = await _productService.CreateProductAsync(product);
                return Ok(productAdded);
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    Error = ex.Message,
                });
            }
        }
        [HttpPut]
        public async Task<ActionResult> UpdateProductAsync(Product product, int productId)
        {
            try
            {
                var productUpdated = await _productService.UpdateProductAsync(product, productId);
                return Ok(productUpdated);
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    Error = ex.Message,
                });
            }
        }

        [HttpPatch]
        public async Task<ActionResult> UpdatePatchProductAsync(Product product, int productId)
        {
            try
            {
                var productUpdated = await _productService.UpdateProductAsync(product, productId);
                return Ok(productUpdated);
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    Error = ex.Message,
                });
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProductAsync(int productId)
        {
            try
            {
                var productDeleted = await _productService.DeleteProductAsync(productId);
                return Ok(productDeleted);
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    Error = ex.Message,
                });
            }
        }
    }
}
