using ProductsInventory.API.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInventory.API.Services
{
    public interface IEmailRepository
    {
        IEnumerable<Email> GetEmail();
        Email GetEmail(int emailId);
        void AddEmail(Email email);
        void UpdateEmail(Email email);
        void DeleteEmail(Email email);
        bool EmailExists(int emailId);
        bool Save();
    }
}
