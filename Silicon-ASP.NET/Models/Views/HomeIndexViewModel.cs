using Silicon_ASP.NET.Models.Sections;

namespace Silicon_ASP.NET.Models.Views;

public class HomeIndexViewModel
{
    public string Title { get; set; } = "";
    public ShowcaseViewModel Showcase { get; set; } = null!;
}
