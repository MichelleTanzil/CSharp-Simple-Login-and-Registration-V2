using System.ComponentModel.DataAnnotations;
namespace simple_login_registration_version_two.Models
{
    public class UserRegistration
    {
        [Required]
        [MinLength(2)]
        [Display(Name="First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name="Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        [ConfirmPasswordAttribute]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}