using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace User_API.InputModel
{
    public class UserInputModel
    {

        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "First name must have between 5 and 50 characteres.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Last name must have between 5 and 50 characteres.")]
        public string LastName { get; set; }

        [Required]
        [Range(12, 100, ErrorMessage = "Age must be at least 12 to 100.")]
        public int Age { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Email must have between 10 and 50 characteres.")]
        public string Email { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must have between 3 and 50 characteres.")]
        public string Username { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Password must have at least 5 characteres.")]
        public string Password { get; set; }

    }
}
