﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsInventory.API.Models
{
    public class ProductDto
    {

        public int productId { get; set; }
        
        public string productName { get; set; }

        public string productCode { get; set; }

        public string releaseDate { get; set; }

        public string description { get; set; }

        public decimal price { get; set; }

        public decimal starRating { get; set; }

        public string imageUrl { get; set; }
    }
}
