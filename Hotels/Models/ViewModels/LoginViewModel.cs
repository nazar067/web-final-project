﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotels.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        //[EmailAddress]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
    }
}
