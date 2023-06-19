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
                ObjectCount = chart.ObjectCount,
                FilePath = chart.FilePath,
                ChartSetId = chart.ChartSetId,
                ChartSet = chart.ChartSet
            }).OrderBy(c => c.CreationDate).ToList();
        }
        public async Task CreateAsync(ChartViewModel model, IFormFile file)
        {
            Chart chart = new()
            {
                Id = Guid.NewGuid().ToString(),
                DifficultyName = model.DifficultyName,
                DifficultyRating = model.DifficultyRating,
                CreationDate = DateTime.Now,
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
                model.Id = chart.Id;
                chart.FilePath = await UploadFile(model, file);
            }

            await _context.Charts.AddAsync(chart);
            await _context.SaveChangesAsync();
        }
        public async Task<string> UploadFile(ChartViewModel model, IFormFile file)
        {
            var folderPath = Path.Combine(_environment.WebRootPath, $@"Charts/{model.ChartSetId}");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            var dbFilePath = $@"Charts/{model.ChartSetId}/{model.DifficultyName}{Path.GetExtension(file.FileName)}";
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
        public async Task<FileContentResult> DownloadFileAsync(ChartViewModel model, ControllerBase controller)
        {
            Chart? chart = await _context.Charts.FindAsync(model.Id);

            var filePath = $@"Charts/{chart.ChartSetId}/{chart.DifficultyName}{Path.GetExtension(chart.FilePath)}";
            var fullPath = Path.Combine(_environment.WebRootPath, filePath);

            ChartSet? chartSet = await _context.ChartSets.FindAsync(chart.ChartSetId);
            if (chartSet != null)
            {
                chartSet.PlayCount += 1;
                _context.ChartSets.Update(chartSet);
            }
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
                chart.ObjectCount = model.ObjectCount;
                chart.ChartSetId = model.ChartSetId;
                chart.ChartSet = model.ChartSet;

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
