using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryExpressProject.Models
{
    public class Driver_Details
    {
        [Key]
        public int Driver_Id { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string FullName { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string License_Number { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string Phone_Number { get; set; }

    }
}
