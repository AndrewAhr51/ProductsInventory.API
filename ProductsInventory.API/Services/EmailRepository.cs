using ProductsInventory.API.DbContexts;
using ProductsInventory.API.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductsInventory.API.Services
{
    public class EmailRepository : IEmailRepository, IDisposable
    {

        private readonly ProductsInventoryContext _context;

        public EmailRepository(ProductsInventoryContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void AddEmail(Email email)
        {
            if (email == null)
            {
                throw new ArgumentNullException(nameof(email));
            }

            _context.Emails.Add(email);
        }

        public void DeleteEmail(Email email)
        {
            if (email == null)
            {
                throw new ArgumentNullException(nameof(email));
            }

            _context.Emails.Remove(email);
        }

        public Email GetEmail(int emailId)
        {
            if (emailId <= 0)
            {
                throw new ArgumentNullException(nameof(emailId));
            }

            return _context.Emails
              .Where(p => p.EmailId == emailId).FirstOrDefault();
        }

        public IEnumerable<Email> GetEmail()
        {
            return _context.Emails.ToList<Email>();
        }

        public bool EmailExists(int emailId)
        {
            if (emailId <= 0)
            {
                throw new ArgumentNullException(nameof(emailId));
            }

            return _context.Emails.Any(a => a.EmailId == emailId);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateEmail(Email email)
        {
            if (email == null)
            {
                throw new ArgumentNullException(nameof(email));
            }

            _context.Emails.Update(email);
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
