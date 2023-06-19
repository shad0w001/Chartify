using Microsoft.AspNetCore.Identity;

namespace Chartify.Models
{
    public class User : IdentityUser
    {
        public DateTime CreationDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public string ProfilePicturePath { get; set; } = "Users/ProfilePictures/default.png";
        public string ProfileBannerPath { get; set; } = "Users/ProfileBanners/default.png";

        //
        public List<ChartSet>? ChartSets { get; set; } = new List<ChartSet>();
        public User() : base() { }
    }
}
