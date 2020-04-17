using ProductsInventory.API.DbContexts;
using ProductsInventory.API.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductsInventory.API.Services
{
    public class CustomerRepository : ICustomerRepository, IDisposable
    {

        private readonly ProductsInventoryContext _context;

        public CustomerRepository(ProductsInventoryContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void AddCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            _context.Customers.Add(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            _context.Customers.Remove(customer);
        }

        public Customer GetCustomer(int customerId)
        {
            if (customerId <= 0)
            {
                throw new ArgumentNullException(nameof(customerId));
            }

            return _context.Customers
              .Where(p => p.CustomerId == customerId).FirstOrDefault();
        }

        public IEnumerable<Customer> GetCustomer()
        {
            return _context.Customers.ToList<Customer>();
        }

        public bool CustomerExists(int customerId)
        {
            if (customerId <= 0)
            {
                throw new ArgumentNullException(nameof(customerId));
            }

            return _context.Customers.Any(a => a.CustomerId == customerId);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            _context.Customers.Update(customer);
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
