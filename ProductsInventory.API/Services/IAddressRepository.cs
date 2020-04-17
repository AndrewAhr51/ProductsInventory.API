using ProductsInventory.API.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInventory.API.Services
{
    public interface IAddressRepository
    {
        IEnumerable<Address> GetAddress();
        Address GetAddress(int addressId);
        void AddAddress(Address address);
        void UpdateAddress(Address address);
        void DeleteAddress(Address address);
        bool AddressExists(int addressId);
        bool Save();
    }
}
