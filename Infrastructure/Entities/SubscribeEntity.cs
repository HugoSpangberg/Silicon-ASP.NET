
namespace Infrastructure.Entities;

public class SubscribeEntity
{
    public int Id { get; set; }
    public bool DailyNewsletter { get; set; }
    public bool AdvertisingUpdate { get; set; }
    public bool WeekInReview { get; set; }
    public bool EventUpdates { get; set; }
    public bool StartupsWeekly { get; set; }
    public bool Podcasts { get; set; }
    public string Email { get; set; } = null!;
}
