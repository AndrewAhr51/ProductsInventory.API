using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsInventory.API.Models
{
    public class ProductForUpdateDto
    {
        public string productName { get; set; }

        public string productCode { get; set; }

        public string releaseDate { get; set; }

        public string description { get; set; }

        public decimal price { get; set; }

        public decimal starRating { get; set; }

        public string imageUrl { get; set; }
    }
}
