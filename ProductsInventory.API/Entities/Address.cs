using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProductsInventory.API.Entities
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage ="The maximum length for address is 30")]
        public string Address1 { get; set; }
        [MaxLength(30, ErrorMessage = "The maximum length for address is 30")]
        public string Address2 { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "The maximum length for address is 30")]
        public string City { get; set; }
        [Required]
        [MaxLength(2, ErrorMessage = "The maximum length for address is 2")]
        public string State { get; set; }
        [Required]
        [MaxLength(9, ErrorMessage = "The maximum length for address is 9")]
        public string ZipCode { get; set; }

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
    }
}
