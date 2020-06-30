using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage ="User Name is required!")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must contain at least 5 characters, and no more than 15 characters.")]
        public string Username { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage ="Password is required!")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must contain at least 6 characters, and no more than 20 characters.")]
        public string Password { get; set; }
        
        [Required(ErrorMessage ="Must confirm password!")]
        [Compare("Password", ErrorMessage = "The passwords don't match.")]
        public string VerifyPassword { get; set; }

    }
}
