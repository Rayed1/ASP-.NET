using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FormValidation.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Name is required.")]

        [StringLength(50, MinimumLength = 4, ErrorMessage = "Name must be between 4 and 50 characters.")]

        [RegularExpression(@"^[A-Za-z ._\-]+$", ErrorMessage = "Name can only contain letters, space, dot, underscore, and dash.")]

        public string Name { get; set; }

        [Required(ErrorMessage = "User ID is required.")]

        [StringLength(12, MinimumLength = 4, ErrorMessage = "User ID must be between 4 and 12 characters.")]

        [RegularExpression(@"^[A-Za-z0-9_-]+$", ErrorMessage = "User ID can only contain letters, numbers, underscore, and dash.")]

        public string UserId { get; set; }



        [Required(ErrorMessage = "Password is required.")]

        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z]{2})[A-Za-z0-9!@#$%^&*()-_=+]{8,}$", ErrorMessage = "Invalid password format.")]

        public string Password { get; set; }



        [Required(ErrorMessage = "ID is required.")]
        [RegularExpression(@"^\d{2}-\d{5}-\d$", ErrorMessage = "Invalid ID format. It should be XX-XXXXX-X where X is a numeric value.")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression(@"^(\d{2}-\d{5}-\d)@student.aiub.edu$", ErrorMessage = "Invalid Email format. It should be XX-XXXXX-X@student.aiub.edu where XX values are the same as your ID.")]
        public string Email { get; set; }



        [Required(ErrorMessage = "Date of Birth is required.")]

        [DataType(DataType.Date)]

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime? DateOfBirth { get; set; }

    }
}
