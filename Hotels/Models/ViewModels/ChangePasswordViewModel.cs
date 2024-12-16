using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotels.Models.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        public string OldPass { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string NewPass { get; set; }
        public string ReturnUrl { get; set; }
    }
}
