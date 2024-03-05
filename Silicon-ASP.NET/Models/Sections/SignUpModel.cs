using Silicon_ASP.NET.Helpers;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Silicon_ASP.NET.Models.Sections;

public class SignUpModel
{
    [Display(Name = "First name", Prompt = "Enter your first name", Order = 0)]
    [Required(ErrorMessage = "Invalid first name")]
    public string FirstName { get; set; } = null!;


    [Display(Name = "Last name", Prompt = "Enter your last name", Order = 1)]
    [Required(ErrorMessage = "Invalid last name")]
    public string LastName { get; set; } = null!;

    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Invalid email address")]
    [Display(Name = "Email Address", Prompt = "Enter your email Adress", Order = 2)]
    [RegularExpression("^[a-zA-Z0-9]+@[a-zA-Z0-9]+\\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = null!;

    [DataType(DataType.Password)]

    [Display(Name = "Password", Prompt = "Enter your password", Order = 3)]
    [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@#$%^&+=!]).{8,}$", ErrorMessage = "Invalid password")]
    public string Password { get; set; } = null!;


    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Password must be confirmed")]
    [Display(Name = "Confirm password", Prompt = "Confirm your password", Order = 4)]
    [Compare(nameof(Password), ErrorMessage = "Password does not match")]
    public string ConfirmPassword { get; set; } = null!;

    [Display(Name = "I agree to the Terms & Conditions.", Order = 5)]
    [CheckBoxRequired(ErrorMessage = "You must accept the terms and conditions")]
    public bool Terms { get; set; } = false;
}


