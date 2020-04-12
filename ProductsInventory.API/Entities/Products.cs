using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProductsInventory.API.Entities
{
    public class Products { 
    [Key]
    public int productId { get; set; }

    [Required]
    public string productName { get; set; }

    [Required]
    public string productCode { get; set; }

    [Required]
    public string releaseDate { get; set; }

    [Required]
    public string description { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal price { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,1)")]
    public decimal starRating { get; set; }

    [Required]
    public string imageUrl { get; set; }
}
    }
