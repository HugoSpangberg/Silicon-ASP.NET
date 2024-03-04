using Silicon_ASP.NET.Models.Components;

namespace Silicon_ASP.NET.Models.Sections;

public class ShowcaseViewModel
{
    public string? Id { get; set; }
    public ImageViewModels ShowcaseImage { get; set; } = null!;
    public string? Title { get; set; }
    public string? Text { get; set; }
    public LinkViewModels Link { get; set; } = new LinkViewModels();
    public string? BrandsText { get; set; }
    public List<ImageViewModels>? Brands { get; set; }
}
