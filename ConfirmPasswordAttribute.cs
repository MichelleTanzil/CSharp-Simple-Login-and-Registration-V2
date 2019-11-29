using System.ComponentModel.DataAnnotations;
using simple_login_registration_version_two.Models;
namespace simple_login_registration_version_two
{
    public class ConfirmPasswordAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var user = (UserRegistration)validationContext.ObjectInstance;
            if (user.Password != user.ConfirmPassword)
            {
                return new ValidationResult("Passwords must match!");
            }
            return ValidationResult.Success;
        }
    }
}