using ProductsInventory.API.DbContexts;
using ProductsInventory.API.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductsInventory.API.Services
{
    public class AddressRepository : IAddressRepository, IDisposable
    {

        private readonly ProductsInventoryContext _context;

        public AddressRepository(ProductsInventoryContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void AddAddress(Address address)
        {
            if (address == null)
            {
                throw new ArgumentNullException(nameof(address));
            }

            _context.Addresses.Add(address);
        }

        public void DeleteAddress(Address address)
        {
            if (address == null)
            {
                throw new ArgumentNullException(nameof(address));
            }

            _context.Addresses.Remove(address);
        }

        public Address GetAddress(int addressId)
        {
            if (addressId <= 0)
            {
                throw new ArgumentNullException(nameof(addressId));
            }

            return _context.Addresses
              .Where(p => p.AddressId == addressId).FirstOrDefault();
        }

        public IEnumerable<Address> GetAddress()
        {
            return _context.Addresses.ToList<Address>();
        }

        public bool AddressExists(int addressId)
        {
            if (addressId <= 0)
            {
                throw new ArgumentNullException(nameof(addressId));
            }

            return _context.Addresses.Any(a => a.CustomerId == addressId);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateAddress(Address address)
        {
            if (address == null)
            {
                throw new ArgumentNullException(nameof(address));
            }

            _context.Addresses.Update(address);
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
