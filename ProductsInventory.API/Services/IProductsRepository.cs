using ProductsInventory.API.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInventory.API.Services
{
    public interface IProductsRepository
    {
        IEnumerable<Products> GetProducts();
        Products GetProduct(int productsId);
        void AddProduct(Products products);
        void UpdateProducts(Products products);
        void DeleteProducts(Products products);
        bool ProductsExists(int productsId);
        bool Save();
    }
}
