using ProductsInventory.API.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInventory.API.Services
{
    public interface ITagRepository
    {
        IEnumerable<Tag> GetTag();
        Tag GetTag(int tagId);
        void AddTag(Tag tag);
        void UpdateTag(Tag tag);
        void DeleteTag(Tag tag);
        bool TagExists(int tagId);
        bool Save();
    }
}
