using Chartify.Data;
using Chartify.Models;
using Chartify.Services;
using Chartify.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Chartify.Controllers
{
    public class ChartController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public ChartServices Services { get; set; }
        public ChartSetServices _csServices { get; set; }

        public ChartController(ApplicationDbContext context, 
            ChartServices services, 
            ChartSetServices csServices,
            UserManager<User> userManager,
            SignInManager<User> signInManager)
        {
            _context = context;
            Services = services;
            _csServices = csServices;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<ChartViewModel> charts = Services.GetAll();

            return View(charts);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            if (User.IsInRole("Admin"))
            {
                ViewBag.ChartSets = _csServices.GetChartSetList(_csServices.GetAll());
            }
            else
            {
                string currentUserId = _userManager.GetUserId(User);
                ViewBag.ChartSets = _csServices.GetChartSetList(_csServices.GetUserChartSets(currentUserId));
            }            
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(ChartViewModel model, IFormFile file)
        {
            await Services.CreateAsync(model, file);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "ChartSet");
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> UploadFile(string? id, IFormFile file)
        {
            if (id == null)
            {
                return NotFound();
            }

            ChartViewModel model = Services.GetDetailsById(id);

            if (model == null)
            {
                return NotFound();
            }

            Chart? chart = await _context.Charts.FindAsync(id);

            if (chart != null)
            {
                chart.FilePath = await Services.UploadFile(model, file);
                _context.Charts.Update(chart);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index", "ChartSet");
        }

        [HttpGet]
        public IActionResult Details(string? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            ChartViewModel model = Services.GetDetailsById(id);

            if(model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Download(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ChartViewModel model = Services.GetDetailsById(id);

            if (model == null)
            {
                return NotFound();
            }

            return await Services.DownloadFileAsync(model, this);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Update(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ChartViewModel model = Services.GetDetailsById(id);

            if (model == null)
            {
                return NotFound();
            }

            if (User.IsInRole("Admin"))
            {
                ViewBag.ChartSets = _csServices.GetChartSetList(_csServices.GetAll());
            }
            else
            {
                string currentUserId = _userManager.GetUserId(User);
                ViewBag.ChartSets = _csServices.GetChartSetList(_csServices.GetUserChartSets(currentUserId));
            }
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Update(ChartViewModel model, IFormFile file)
        {
            await Services.UpdateAsync(model, file);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "ChartSet");
        }

        [HttpGet]
        [Authorize]
        public IActionResult Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ChartViewModel model = Services.GetDetailsById(id);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Delete(ChartViewModel model)
        {
            await Services.DeleteAsync(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "ChartSet");
        }
    }
}
