using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInventory.API.Models
{
    public class TagForCreationDto
    {
        public int TagId { get; set; }

        public string TagName { get; set; }

        public int ProductId { get; set; }
    }
}
