using Silicon_ASP.NET.Models.Sections;

namespace Silicon_ASP.NET.ViewModels.Sections;

public class SignInViewModel
{
    public string Title { get; set; } = "Sign in";

    public SignInModel Form { get; set; } = new SignInModel();

    public string? ErrorMessage { get; set; }
}
