﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInventory.API.Models
{
    public class AddressDto
    {
        public int AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string CustomerId { get; set; }
    }
}
