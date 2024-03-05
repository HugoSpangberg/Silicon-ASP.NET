using System.ComponentModel.DataAnnotations;

namespace Silicon_ASP.NET.Models.Sections;

public class SignInModel
{
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Invalid email address")]
    [Display(Name = "Email Address", Prompt = "Enter your email Adress", Order = 0)]

    public string Email { get; set; } = null!;

    [DataType(DataType.Password)]
    [Display(Name = "Password", Prompt = "Enter your password", Order = 1)]
    public string Password { get; set; } = null!;


    [Display(Name = "Remeber me", Order = 2)]
    public bool RememberMe { get; set; }
}
