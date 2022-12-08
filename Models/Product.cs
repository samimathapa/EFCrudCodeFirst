﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreCodeFirstCrudApp.Models
{
    public class Product
    {
        [Key]
        [Column("pid", Order = 0)]
        [Display(Name = "Product Id")]
        public int Id { get; set; }
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        [Required]
        [Range(0, 99999999999999)]
        public int Quantity { get; set; }
        [Required]
        [Range(0, 99999999999999)]
        public double Price { get; set; }
    }
}