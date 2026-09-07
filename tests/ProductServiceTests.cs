using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using src.Data;
using src.Models;
using src.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace tests
{
    public class ProductServiceTests
    {
        private readonly ProductService _productService;
        private readonly Mock<ApplicationDbContext> _mockContext;

        public ProductServiceTests()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase(databaseName: "TestDatabase")
               .Options;

            _mockContext = new Mock<ApplicationDbContext>(options);
            _productService = new ProductService(_mockContext.Object);
        }

        [Fact]
        public async Task GetAllProducts_ReturnsAllProducts()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Product1", Price = 10.0m, Stock = 10, Category = "Category1" },
                new Product { Id = 2, Name = "Product2", Price = 20.0m, Stock = 20, Category = "Category2" }
            };
            _mockContext.Setup(c => c.Products).Returns(DbSetMock.Create(products));

            // Act
            var result = await _productService.GetAllProducts();

            // Assert
            Assert.Equal(products, result);
        }

        [Fact]
        public async Task GetProductById_ReturnsProduct()
        {
            // Arrange
            var product = new Product { Id = 1, Name = "Product1", Price = 10.0m, Stock = 10, Category = "Category1" };
            _mockContext.Setup(c => c.Products).Returns(DbSetMock.Create(new List<Product> { product }));

            // Act
            var result = await _productService.GetProductById(1);

            // Assert
            Assert.Equal(product, result);
        }

        [Fact]
        public async Task CreateProduct_CreatesProduct()
        {
            // Arrange
            var product = new Product { Name = "Product3", Price = 30.0m, Stock = 30, Category = "Category3" };

            // Act
            var result = await _productService.CreateProduct(product);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(product.Name, result.Name);
        }

        [Fact]
        public async Task UpdateProduct_UpdatesProduct()
        {
            // Arrange
            var product = new Product { Id = 1, Name = "Product1", Price = 10.0m, Stock = 10, Category = "Category1" };
            _mockContext.Setup(c => c.Products).Returns(DbSetMock.Create(new List<Product> { product }));

            var updatedProduct = new Product { Id = 1, Name = "Product1Updated", Price = 15.0m, Stock = 15, Category = "Category1Updated" };

            // Act
            var result = await _productService.UpdateProduct(1, updatedProduct);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(updatedProduct.Name, result.Name);
        }

        [Fact]
        public async Task DeleteProduct_DeletesProduct()
        {
            // Arrange
            var product = new Product { Id = 1, Name = "Product1", Price = 10.0m, Stock = 10, Category = "Category1" };
            _mockContext.Setup(c => c.Products).Returns(DbSetMock.Create(new List<Product> { product }));

            // Act
            await _productService.DeleteProduct(1);

            // Assert
            Assert.Empty(_mockContext.Object.Products);
        }
    }
}