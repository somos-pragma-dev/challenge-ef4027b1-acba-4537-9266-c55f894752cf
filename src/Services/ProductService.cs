using Microsoft.EntityFrameworkCore;
using src.Data;
using src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Services
{
    public class ProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<Product> CreateProduct(Product product)
        {
            if (product.Price < 0)
            {
                throw new ArgumentException("El precio no puede ser negativo");
            }

            if (_context.Products.Any(p => p.Name == product.Name))
            {
                throw new ArgumentException("El nombre del producto ya existe");
            }

            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> UpdateProduct(int id, Product product)
        {
            var existingProduct = await _context.Products.FindAsync(id);
            if (existingProduct == null)
            {
                throw new ArgumentException("El producto no existe");
            }

            if (product.Price < 0)
            {
                throw new ArgumentException("El precio no puede ser negativo");
            }

            if (_context.Products.Any(p => p.Name == product.Name && p.Id!= id))
            {
                throw new ArgumentException("El nombre del producto ya existe");
            }

            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            existingProduct.Stock = product.Stock;
            existingProduct.Category = product.Category;

            _context.Entry(existingProduct).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return existingProduct;
        }

        public async Task DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                throw new ArgumentException("El producto no existe");
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}