﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class RegisterViewModel
    {
            [Required]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [Display(Name = "Year")]
            public int Year { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [Required]
            [Compare("Password", ErrorMessage = "Invalid password")]
            [DataType(DataType.Password)]
            [Display(Name = "Accept password")]
            public string PasswordConfirm { get; set; }
    }
}
