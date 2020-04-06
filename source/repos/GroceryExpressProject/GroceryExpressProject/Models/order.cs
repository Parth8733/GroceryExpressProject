using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryExpressProject.Models
{
    public class order
    {
        [Key]
        public int Order_Id { get; set; }
        [Column(TypeName= "int")]
        public int Customer_id { get; set; }
        [Column(TypeName = "int")]
        public int Product_id { get; set; }
        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Product_Name { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int Quantity { get; set; }
        [Column(TypeName = "int")]
        [Required]
        public int Price { get; set; }
       

    }
}
