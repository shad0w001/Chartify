using Chartify.Models;
using Microsoft.AspNetCore.Identity;

namespace Chartify.ViewModels
{
    public class UserViewModel : IdentityUser
    {
        public DateTime CreationDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public string ProfilePicturePath { get; set; }
        public string ProfileBannerPath { get; set; }
        public List<User>? Subscribers { get; set; }
        public List<User>? SubscribedTo { get; set; }
        public List<ChartSet>? ChartSets { get; set; }
        public UserViewModel() : base() { }
    }
}
