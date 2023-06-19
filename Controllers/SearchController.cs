using Chartify.Data;
using Chartify.Models;
using Chartify.Services;
using Chartify.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Chartify.Controllers
{
    public class SearchController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public UserServices _userServices { get; set; }
        public ChartSetServices _csServices { get; set; }

        public SearchController(ApplicationDbContext context,
            UserServices userServices,
            ChartSetServices csServices,
            UserManager<User> userManager,
            SignInManager<User> signInManager)
        {
            _context = context;
            _userServices = userServices;
            _csServices = csServices;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Search(string searchTerm)
        {
            SearchViewModel model = new SearchViewModel();

            model.SearchCriteria = searchTerm;

            var chartsetList = _csServices.GetAll();
            model.ChartSetResults = chartsetList
                .Where(c => c.Artist.Contains(searchTerm) || c.Title.Contains(searchTerm) || c.Creator.UserName.Contains(searchTerm));

            var userList = _userServices.GetAll();
            model.UserResults = userList
                .Where(u => u.UserName.Contains(searchTerm));

            return View(model);
        }
    }
}
