using Chartify.Data;
using Chartify.Models;
using Chartify.Services;
using Chartify.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Chartify.Controllers
{
    public class ChartSetController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public ChartSetServices Services { get; set; }

        public ChartSetController(ApplicationDbContext context,
            ChartSetServices services,
            UserManager<User> userManager,
            SignInManager<User> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            Services = services;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var chartests = Services.GetAll();

            return View(chartests);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ChartSetViewModel model, IFormFile file)
        {
            string currentUserId = _userManager.GetUserId(User);
            await Services.CreateAsync(model, file, currentUserId);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> Download(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ChartSetViewModel model = Services.GetDetailsById(id);

            if (model == null)
            {
                return NotFound();
            }

            await Services.Download(model, this);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Details(string? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            ChartSetViewModel model = Services.GetDetailsById(id);

            if(model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Update(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ChartSetViewModel model = Services.GetDetailsById(id);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ChartSetViewModel model, IFormFile file)
        {
            await Services.UpdateAsync(model, file);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ChartSetViewModel model = Services.GetDetailsById(id);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ChartSetViewModel model)
        {
            await Services.DeleteAsync(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
