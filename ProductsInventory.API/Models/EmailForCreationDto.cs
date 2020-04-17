using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInventory.API.Models
{
    public class EmailForCreationDto
    {
        public string EmailAddress { get; set; }
        public int CustomerId { get; set; }
    }
}
