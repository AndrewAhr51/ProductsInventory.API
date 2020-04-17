using ProductsInventory.API.DbContexts;
using ProductsInventory.API.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductsInventory.API.Services
{
    public class ProductsRepository : IProductsRepository, IDisposable
    {

        private readonly ProductsInventoryContext _context;

        public ProductsRepository(ProductsInventoryContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void AddProduct(Products products)
        {
            if (products == null)
            {
                throw new ArgumentNullException(nameof(products));
            }

            _context.Products.Add(products);
        }

        public void DeleteProducts(Products products)
        {
            if (products == null)
            {
                throw new ArgumentNullException(nameof(products));
            }

            _context.Products.Remove(products);
        }

        public Products GetProduct(int productId)
        {
            if (productId <= 0)
            {
                throw new ArgumentNullException(nameof(productId));
            }

            return _context.Products
              .Where(p => p.productId == productId).FirstOrDefault();
        }

        public IEnumerable<Products> GetProducts()
        {
            return _context.Products.ToList<Products>();
        }

        public bool ProductsExists(int productId)
        {
            if (productId <= 0)
            {
                throw new ArgumentNullException(nameof(productId));
            }

            return _context.Products.Any(a => a.productId == productId);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateProducts(Products products)
        {
            if (products == null)
            {
                throw new ArgumentNullException(nameof(products));
            }

            _context.Products.Update(products);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose resources when needed
            }
        }
    }

}
