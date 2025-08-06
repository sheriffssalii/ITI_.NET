﻿using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Register
    {
        
            [Required(ErrorMessage = "First name is required")]
            [StringLength(100)]
            public string FirstName { get; set; }

            [Required(ErrorMessage = "Last name is required")]
            [StringLength(100)]
            public string LastName { get; set; }

            [Required(ErrorMessage = "Email is required")]
            [EmailAddress(ErrorMessage = "Invalid email format")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Password is required")]
            [MinLength(6, ErrorMessage = "Password must be at least 6 characters")]
            [DataType(DataType.Password)]
            public string Password { get; set; }

           
    }
}

