using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProductsInventory.API.Entities
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }
        [Required]
        public string TagName { get; set; }

        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
    }
}
