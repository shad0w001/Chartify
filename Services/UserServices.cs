using Chartify.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Chartify.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using Chartify.Controllers;
using Chartify.Interfaces;
using Chartify.ViewModels;
using LoginTesting.Services.Interfaces;

namespace Chartify.Services
{
    public class UserServices : IUserServices
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IUserStore<User> _userStore;
        private readonly IUserEmailStore<User> _emailStore;
        private readonly ILogger<User> _logger;
        private readonly IEmailSender _emailSender;
        private readonly IWebHostEnvironment _environment;

        private IUserEmailStore<User> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<User>)_userStore;
        }

        public UserServices(ApplicationDbContext context,
            SignInManager<User> signInManager,
            UserManager<User> userManager,
            IUserStore<User> userStore,
            IWebHostEnvironment environment,
            ILogger<User> logger,
            IEmailSender emailSender)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _userStore = userStore;
            _environment = environment;
            _emailStore = GetEmailStore();
            _logger = logger;
            _emailSender = emailSender;
        }

        public List<User> GetAll()
        {
            return _userManager.Users.ToList();            
        }

        public User GetUserById(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;
            return user;
        }
        public List<ChartSet> GetChartsetsForUserProfile(string currentUserId)
        {
            return _context.ChartSets.Where(c => c.CreatorId == currentUserId).ToList();
        }
        public async Task<string> UploadProfilePicture(User user, IFormFile file)
        {
            var folderPath = Path.Combine(_environment.WebRootPath, $@"Users/ProfilePictures/{user.Id}");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            var dbFilePath = $@"Users/ProfilePictures/{user.Id}/pfp{Path.GetExtension(file.FileName)}";
            var filePath = Path.Combine(_environment.WebRootPath, dbFilePath);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            using var fileStream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(fileStream);
            dbFilePath = $"/{dbFilePath}";
            return dbFilePath;
        }
        public async Task<string> UploadBanner(User user, IFormFile file)
        {
            var folderPath = Path.Combine(_environment.WebRootPath, $@"Users/ProfileBanners/{user.Id}");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            var dbFilePath = $@"Users/ProfileBanners/{user.Id}/banner{Path.GetExtension(file.FileName)}";
            var filePath = Path.Combine(_environment.WebRootPath, dbFilePath);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            using var fileStream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(fileStream);
            dbFilePath = $"/{dbFilePath}";
            return dbFilePath;
        }
    }
}
