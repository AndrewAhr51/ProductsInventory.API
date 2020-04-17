using ProductsInventory.API.DbContexts;
using ProductsInventory.API.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductsInventory.API.Services
{
    public class TagRepository : ITagRepository, IDisposable
    {

        private readonly ProductsInventoryContext _context;

        public TagRepository(ProductsInventoryContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void AddTag(Tag tag)
        {
            if (tag == null)
            {
                throw new ArgumentNullException(nameof(tag));
            }

            _context.Tags.Add(tag);
        }

        public void DeleteTag(Tag tag)
        {
            if (tag == null)
            {
                throw new ArgumentNullException(nameof(tag));
            }

            _context.Tags.Remove(tag);
        }

        public Tag GetTag(int tagId)
        {
            if (tagId <= 0)
            {
                throw new ArgumentNullException(nameof(tagId));
            }

            return _context.Tags
              .Where(p => p.TagId == tagId).FirstOrDefault();
        }

        public IEnumerable<Tag> GetTag()
        {
            return _context.Tags.ToList<Tag>();
        }

        public bool TagExists(int tagId)
        {
            if (tagId <= 0)
            {
                throw new ArgumentNullException(nameof(tagId));
            }

            return _context.Tags.Any(a => a.TagId == tagId);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateTag(Tag tag)
        {
            if (tag == null)
            {
                throw new ArgumentNullException(nameof(tag));
            }

            _context.Tags.Update(tag);
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
