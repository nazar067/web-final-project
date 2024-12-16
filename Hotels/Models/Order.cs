using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotels.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter your last name")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Enter your phone")]
        public int Phone { get; set; }
        [Required(ErrorMessage = "Enter your Email")]
        public string Email { get; set; }
        public int HotelsId { get; set; }
    }
}
