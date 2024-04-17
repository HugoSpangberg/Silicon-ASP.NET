using System.ComponentModel.DataAnnotations;

namespace Silicon_ASP.NET.ViewModels;

public class SubscribeViewModel
{
    [Display(Name = "Daily Newsletter")]
    public bool DailyNewsletter { get; set; }

    [Display(Name = "Advertising Update")]
    public bool AdvertisingUpdate { get; set; }

    [Display(Name = "Week in Review")]
    public bool WeekInReview { get; set; }

    [Display(Name = "Event Updates")]
    public bool EventUpdates { get; set; }

    [Display(Name = "Startups Weekly")]
    public bool StartupsWeekly { get; set; }

    [Display(Name = "Podcasts")]
    public bool Podcasts { get; set; }

    [Required]
    [DataType(DataType.EmailAddress)]
    [Display(Name = "Email Address", Prompt = "Your Email")]
    public string Email { get; set; } = null!;

    public string Message { get; set; } = null!;
}
