using Silicon_ASP.NET.Models.Sections;

namespace Silicon_ASP.NET.ViewModels.Sections;

public class SignUpViewModel
{
    public string Title { get; set; } = "Sign up";
    public SignUpModel Form { get; set; } = new SignUpModel();

}
