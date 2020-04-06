using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryExpressProject.Models
{
    public class Customer_Details
    {
        [Key]
        public int Customer_Id { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string FullName { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Address { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string City { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string Phone_Number { get; set; }

    }
}
