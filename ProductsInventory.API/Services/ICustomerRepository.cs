using ProductsInventory.API.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInventory.API.Services
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomer();
        Customer GetCustomer(int customerId);
        void AddCustomer(Customer Customers);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        bool CustomerExists(int customerId);
        bool Save();
    }
}
