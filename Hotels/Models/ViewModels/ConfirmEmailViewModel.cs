using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotels.Models.ViewModels
{
    public class ConfirmEmailViewModel
    {
        [Required]
        public string Password { get; set; }
    }
}
