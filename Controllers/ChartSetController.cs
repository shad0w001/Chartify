using Chartify.Data;
using Chartify.Models;
using Chartify.Services;
using Chartify.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
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
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(ChartSetViewModel model, IFormFile file)
        {
            string currentUserId = _userManager.GetUserId(User);
            await Services.CreateAsync(model, file, currentUserId);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> UploadCover(string? id, IFormFile file)
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

            ChartSet? chartset = await _context.ChartSets.FindAsync(id);

            if(chartset != null)
            {
                chartset.CoverPath = await Services.UploadCover(model, file);
                _context.ChartSets.Update(chartset);
                await _context.SaveChangesAsync();
            }

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

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Approve(string? id)
        {
            if (id == null)
            {
                NotFound();
            }

            ChartSetViewModel model = Services.GetDetailsById(id);

            if (model == null)
            {
                NotFound();
            }

            await Services.ApproveAsync(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Authorize]
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
        [Authorize]
        public async Task<IActionResult> Update(ChartSetViewModel model, IFormFile file)
        {
            await Services.UpdateAsync(model, file);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Authorize]
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
        [Authorize]
        public async Task<IActionResult> Delete(ChartSetViewModel model)
        {
            await Services.DeleteAsync(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
