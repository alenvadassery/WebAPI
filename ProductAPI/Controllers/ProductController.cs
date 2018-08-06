using ProductAPI.DAL;
using ProductAPI.EntityModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ProductAPI.Controllers
{
    public class ProductController : ApiController
    {
        IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        [HttpGet]
        public Product GetProductDetails(int productID)
        {
            return _productRepository.GetProductDetails(productID);
        }

        [HttpPost]
        public int AddNewProduct(Product product)
        {
            return _productRepository.AddNewProduct(product);
        }

        [HttpPost]
        public bool UpdateProduct(Product product)
        {
            return _productRepository.UpdateProduct(product);
        }

        [HttpPost]
        public bool DeleteProduct(int productID)
        {
            return _productRepository.DeleteProduct(productID);
        }
    }
}
