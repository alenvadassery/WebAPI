using ProductAPI.EntityModel;
using System.Collections.Generic;

namespace ProductAPI.DAL
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProductDetails(int productID);
        int AddNewProduct(Product product);
        bool UpdateProduct(Product product);
        bool DeleteProduct(int productID);
    }
}