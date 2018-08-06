using ProductAPI.EntityModel;
using System.Collections.Generic;
using System.Linq;

namespace ProductAPI.Manager
{
    public class ProductRepository : IProductRepository
    {
        ProductContext _context = new ProductContext();

        public List<Product> GetAllProducts()
        {
            List<Product> products;
            using (_context = new ProductContext())
            {
                products = _context.Products.ToList();
            }

            return products;
        }

        public Product GetProductDetails(int productID)
        {
            Product productDetails = new Product();
            using (_context = new ProductContext())
            {
                productDetails = _context.Products.Where(product => product.ProductID == productID).FirstOrDefault();
            }

            return productDetails;
        }

        public int AddNewProduct(Product product)
        {
            using (_context = new ProductContext())
            {
                _context.Products.Add(product);
                _context.SaveChanges();
            }

            return product.ProductID;
        }

        public bool UpdateProduct(Product product)
        {
            bool isUpdated = false;
            using (_context = new ProductContext())
            {
                Product productToUpdate = _context.Products.Find(product.ProductID);
                if (productToUpdate != null)
                {
                    productToUpdate.Name = product.Name;
                    productToUpdate.Description = product.Description;
                    productToUpdate.Price = product.Price;
                    productToUpdate.Category = product.Category;

                    _context.SaveChanges();
                    isUpdated = true;
                }
            }

            return isUpdated;
        }

        public bool DeleteProduct(int productID)
        {
            bool isDeleted = false;
            using (_context = new ProductContext())
            {
                Product productToDeleted = _context.Products.Find(productID);

                if (productToDeleted != null)
                {
                    _context.Products.Remove(productToDeleted);
                    _context.SaveChanges();
                    isDeleted = true;
                }
            }

            return isDeleted;
        }
    }
}