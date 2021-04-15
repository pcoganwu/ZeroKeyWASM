using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZeroKeyWASM.Server.Models
{
    public class Product
    {
        [Key, Required, Display(Name = "Product ID")]
        public Guid ProductId { get; set; }
        [Required, Display(Name = "Product Name"), MaxLength(250)]
        public string ProductName { get; set; }
        [Required, Display(Name = "Unit Price")]
        [Column("UnitPrice", TypeName = "decimal(10,4)")]
        public decimal UnitPrice { get; set; }
    }
}
