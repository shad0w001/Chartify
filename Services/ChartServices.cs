using Chartify.Data;
using Chartify.Interfaces;
using Chartify.Models;
using Chartify.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Chartify.Services
{
    public class ChartServices : IChartServices
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;
        public ChartServices(ApplicationDbContext post, IWebHostEnvironment environment)
        {
            _context = post;
            _environment = environment;
        }
        public List<ChartViewModel> GetAll()
        {
            return _context.Charts.Include(c => c.ChartSet)
                .Select(chart => new ChartViewModel()
            {
                Id = chart.Id,
                DifficultyName = chart.DifficultyName,
                DifficultyRating = chart.DifficultyRating,
                CreationDate = chart.CreationDate,
                Duration = chart.Duration,
                ObjectCount = chart.ObjectCount,
                FilePath = chart.FilePath,
                ChartSetId = chart.ChartSetId,
                ChartSet = chart.ChartSet
            }).ToList();
        }
        public async Task CreateAsync(ChartViewModel model, IFormFile file)
        {
            Chart chart = new()
            {
                Id = Guid.NewGuid().ToString(),
                DifficultyName = model.DifficultyName,
                DifficultyRating = model.DifficultyRating,
                CreationDate = model.CreationDate,
                Duration = model.Duration,
                ObjectCount = model.ObjectCount,
            };

            ChartSet? chartset = _context.ChartSets.FindAsync(model.ChartSetId).Result;

            if (chartset != null)
            {
                chart.ChartSetId = model.ChartSetId;
                chart.ChartSet = chartset;
            }

            if (file != null)
            {
                await UploadFile(chart, file);
            }

            await _context.Charts.AddAsync(chart);
            await _context.SaveChangesAsync();
        }
        public async Task<string> UploadFile(Chart chart, IFormFile file)
        {
            var folderPath = Path.Combine(_environment.WebRootPath, $@"Charts/{chart.ChartSetId}");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            var dbFilePath = $@"Charts/{chart.ChartSetId}/{chart.DifficultyName}{Path.GetExtension(file.FileName)}";
            var filePath = Path.Combine(_environment.WebRootPath, dbFilePath);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            using var fileStream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(fileStream);
            chart.FilePath = $"/{dbFilePath}";
            return dbFilePath;
        }
        public async Task<FileContentResult> DownloadFileAsync(ChartViewModel model, ControllerBase controller)
        {
            Chart? chart = await _context.Charts.FindAsync(model.Id);

            var filePath = $@"Charts/{chart.ChartSetId}/{chart.DifficultyName}";
            var fullPath = Path.Combine(_environment.WebRootPath, filePath);

            return controller.File(File.ReadAllBytes(fullPath), "application/octet-stream", Path.GetFileName(fullPath));
        }
        public ChartViewModel GetDetailsById(string id)
        {
            ChartViewModel? model = _context.Charts.Select(chart => new ChartViewModel
            {
                Id = chart.Id,
                DifficultyName = chart.DifficultyName,
                DifficultyRating = chart.DifficultyRating,
                CreationDate = chart.CreationDate,
                Duration = chart.Duration,
                ObjectCount = chart.ObjectCount,
                FilePath = chart.FilePath,
                ChartSetId = chart.ChartSetId,
                ChartSet = chart.ChartSet
            }).SingleOrDefault(set => set.Id == id);

            return model;
        }
        public async Task UpdateAsync(ChartViewModel model, IFormFile file)
        {
            Chart? chart = await _context.Charts.FindAsync(model.Id);

            if (chart != null)
            {
                chart.Id = model.Id;
                chart.DifficultyName = model.DifficultyName;
                chart.DifficultyRating = model.DifficultyRating;
                chart.CreationDate = model.CreationDate;
                chart.Duration = model.Duration;
                chart.ObjectCount = model.ObjectCount;
                chart.ChartSetId = model.ChartSetId;
                chart.ChartSet = model.ChartSet;

                if(file != null)
                {
                    await UploadFile(chart, file);
                }

                _context.Charts.Update(chart);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteAsync(ChartViewModel model)
        {
            Chart? chart = await _context.Charts.FindAsync(model.Id);

            var folderPath = Path.Combine(_environment.WebRootPath, $@"Charts/{chart.ChartSetId}");
            var filePath = $@"Charts/{chart.ChartSetId}/{chart.DifficultyName}";
            var fullPath = Path.Combine(_environment.WebRootPath, filePath);

            if (Directory.Exists(folderPath))
            {
                File.Delete(fullPath);
            }

            if (Directory.GetFileSystemEntries(folderPath).Length == 0)
            {
                Directory.Delete(folderPath);
            }

            if (chart != null)
            {
                _context.Charts.Remove(chart);
                await _context.SaveChangesAsync();
            }
        }
    }
}
