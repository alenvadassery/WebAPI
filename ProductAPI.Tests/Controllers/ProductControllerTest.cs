using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductAPI;
using ProductAPI.Controllers;
using ProductAPI.DAL;
using Moq;
using System.Linq;
using System.Collections.Generic;
using ProductAPI.EntityModel;

namespace ProductAPI.Tests.Controllers
{
    [TestClass]
    public class ProductControllerTest
    {
        private Mock<IProductRepository> mock;

        private IProductRepository getTestObject() {
           return  new ProductRepository();
        }
        

      

        [TestMethod]
        public void GetAllProducts()
        {
            List<Product> testProducts = new List<Product>()
            {
                new Product
                {
                    ProductID = 1,
                    Name = "Name1",
                    Description = "Description1",
                    Price = 100,
                    Category = "TestCategory"

                },

                new Product
                {
                    ProductID = 2,
                    Name = "Name2",
                    Description = "Description2",
                    Price = 100,
                    Category = "TestCategory"

                }
            };    
            
            // Arrange
            mock = new Mock<IProductRepository>();
            mock.Setup(product => product.GetAllProducts()).Returns(testProducts);

            var target = new ProductController(mock.Object);

            // Act

            var temp = target.GetAllProducts();

            // Assert
            //Assert.IsNotNull(result);
            //Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
