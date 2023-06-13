using Chartify.Data;
using Chartify.Services;
using Chartify.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Chartify.Controllers
{
    public class ChartController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ChartServices Services { get; set; }

        public ChartController(ApplicationDbContext context, ChartServices services)
        {
            _context = context;
            Services = services;

        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ChartViewModel model)
        {
            await Services.CreateAsync(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
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

        [HttpGet]
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

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ChartViewModel model)
        {
            await Services.UpdateAsync(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
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
        public async Task<IActionResult> Delete(ChartViewModel model)
        {
            await Services.DeleteAsync(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
