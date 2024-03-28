using System.ComponentModel.DataAnnotations;

namespace Silicon_ASP.NET.ViewModels;

public class SignInViewModel
{
    [DataType(DataType.EmailAddress)]
    [Display(Name = "Email", Prompt = "Your email address")]
    public string Email { get; set; } = null!;


    [DataType(DataType.Password)]
    [Display(Name = "Password", Prompt = "Your password")]
    public string Password { get; set; } = null!;

    public bool RememberMe { get; set; }
}
