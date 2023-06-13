using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Chartify.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using Chartify.Data;
using Chartify.Services;
using Microsoft.Extensions.Hosting;

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
        public UserServices _services;

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
            return View(user);
        }

    }
}
