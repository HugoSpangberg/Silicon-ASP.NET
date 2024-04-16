using System.ComponentModel.DataAnnotations;

namespace Silicon_ASP.NET.ViewModels;

public class SubscribeViewModel
{
    public bool DailyNewsletter { get; set; }
    public bool AdvertisingUpdate { get; set; }
    public bool WeekInReview { get; set; }
    public bool EventUpdates { get; set; }
    public bool StartupsWeekly { get; set; }
    public bool Podcasts { get; set; }
    [Required]
    [Display(Name = "Email Address", Prompt = "Your Email")]
    public string Email { get; set; } = null!;
}
