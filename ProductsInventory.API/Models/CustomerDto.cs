using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInventory.API.Models
{
    public class CustomerDto
    {
        public int CustomerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
