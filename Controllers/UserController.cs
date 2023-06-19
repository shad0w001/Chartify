using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Chartify.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using Chartify.Data;
using Chartify.Services;
using Microsoft.Extensions.Hosting;
using Chartify.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Chartify.Controllers
{
    [Route("u")]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IUserStore<User> _userStore;
        private readonly IUserEmailStore<User> _emailStore;
        private readonly ILogger<User> _logger;
        private readonly IEmailSender _emailSender;
        private readonly UserServices _services;

        private IUserEmailStore<User> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<User>)_userStore;
        }
        public UserController(ApplicationDbContext context,
            SignInManager<User> signInManager,
            UserManager<User> userManager,
            IUserStore<User> userStore,
            ILogger<User> logger,
            IEmailSender emailSender,
            UserServices services)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _logger = logger;
            _emailSender = emailSender;
            _services = services;
        }

        [HttpGet]
        [Route("list")]
        public async Task<IActionResult> Index()
        {
            var users = _services.GetAll();
            var userRoles = new Dictionary<string, IList<string>>();

            foreach(var user in users)
            {
                if(user != null)
                {
                    var roles = await _userManager.GetRolesAsync(user);
                    userRoles.Add(user.UserName, (IList<string>)roles);
                }
            }

            ViewBag.UserRoles = userRoles;

            return View(users);
        }

        [HttpGet]
        [Route("profile")]
        public async Task<IActionResult> Profile(string? id)
        {
            if(id == null)
            {
                return RedirectToAction("Index");
            }
            var user = _services.GetUserById(id);
            var userRoles = new Dictionary<string, IList<string>>();

            var roles = await _userManager.GetRolesAsync(user);
            userRoles.Add(user.UserName, (IList<string>)roles);

            if (user == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.UserRoles = userRoles;
            user.ChartSets = _services.GetChartsetsForUserProfile(user.Id);
            return View(user);
        }

        [HttpPost]
        [Authorize]
        [Route("uploadProfilePicture")]
        public async Task<IActionResult> UploadProfilePicture(string? id, IFormFile file)
        {
            if (id == null)
            {
                return NotFound();
            }

            User user = _services.GetUserById(id);

            if (user == null)
            {
                return NotFound();
            }

            user.ProfilePicturePath = await _services.UploadProfilePicture(user, file);
            await _userManager.UpdateAsync(user);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [Authorize]
        [Route("uploadBanner")]
        public async Task<IActionResult> UploadBanner(string? id, IFormFile file)
        {
            if (id == null)
            {
                return NotFound();
            }

            User user = _services.GetUserById(id);

            if (user == null)
            {
                return NotFound();
            }

            user.ProfileBannerPath = await _services.UploadBanner(user, file);
            await _userManager.UpdateAsync(user);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Authorize]
        [Route("update")]
        public IActionResult Update(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = _services.GetUserById(id);

            if (user == null)
            {
                return RedirectToAction("Index");
            }

            return View(user);
        }

    }

}
