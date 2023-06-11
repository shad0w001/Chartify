using Microsoft.AspNetCore.Identity;

namespace Chartify.Models
{
    public class User : IdentityUser
    {
        public DateTime CreationDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public string ProfilePicturePath { get; set; } = "Users/ProfilePictures/default.png";
        public string ProfileBannerPath { get; set; }
        public List<User>? Subscribers { get; set; } = new List<User>();
        public List<User>? SubscribedTo { get; set; } = new List<User>();
        public List<ChartSet>? ChartSets { get; set; } = new List<ChartSet>();
        public User() : base() { }
    }
}
