using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProductsInventory.API.Entities
{
    public class Email
    {
        [Key]
        public int EmailId { get; set; }

        [Required]
        public string EmailAddress { get; set; }

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
    }
}
