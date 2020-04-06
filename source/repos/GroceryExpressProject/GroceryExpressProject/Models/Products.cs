using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryExpressProject.Models
{
    public class Products
    {
        [Key]
        public int Product_Id { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string Product_Name { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Description { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int Price { get; set; }
        [Column(TypeName = "int")]
        [Required]
        public int Quantity { get; set; }
        

    }
}
