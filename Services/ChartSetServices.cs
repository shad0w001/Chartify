using Chartify.Data;
using Chartify.Interfaces;
using Chartify.Models;
using Chartify.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;

namespace Chartify.Services
{
    public class ChartSetServices : IChartSetServices
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;
        private readonly ChartServices _chartServices;
        public ChartSetServices(ApplicationDbContext post, IWebHostEnvironment environment, ChartServices chartServices)
        {
            _context = post;
            _environment = environment;
            _chartServices = chartServices;
        }
        public List<ChartSetViewModel> GetAll()
        {
            return _context.ChartSets.Select(chartset => new ChartSetViewModel()
            {
                Id = chartset.Id,
                CoverPath = chartset.CoverPath,
                Artist = chartset.Artist,
                Title = chartset.Title,
                Description = chartset.Description,
                CreatorId = chartset.CreatorId,
                Creator = chartset.Creator,
                CreationDate = chartset.CreationDate,
                PlayCount = chartset.PlayCount,
                Charts = chartset.Charts
            }).OrderBy(chartset => chartset.CreationDate).ToList();
        }
        public List<ChartSetViewModel> GetUserChartSets(string currentUserId)
        {
            return _context.ChartSets.Select(chartset => new ChartSetViewModel()
            {
                Id = chartset.Id,
                CoverPath = chartset.CoverPath,
                Artist = chartset.Artist,
                Title = chartset.Title,
                Description = chartset.Description,
                CreatorId = chartset.CreatorId,
                Creator = chartset.Creator,
                CreationDate = chartset.CreationDate,
                PlayCount = chartset.PlayCount,
                Charts = chartset.Charts
            }).Where(c => c.CreatorId == currentUserId).ToList();
        }
        public List<ChartViewModel> GetChartsByChartSet(string chartsetId)
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
                }).Where(c => c.ChartSetId == chartsetId).ToList();
        }
        public List<SelectListItem> GetChartSetList(List<ChartSetViewModel> chartsets)
        {
            var list = new List<SelectListItem>();

            list = chartsets.Select(chartset => new SelectListItem()
            {
                Value = chartset.Id,
                Text = $"{chartset.Artist} - {chartset.Title}, made by {chartset.Creator.UserName}",
            }).ToList();

            return list;
        }
        public async Task CreateAsync(ChartSetViewModel model, IFormFile file, string currentUserId)
        {
            User? user = _context.Users.FindAsync(currentUserId).Result;

            ChartSet chartset = new()
            {
                Id = Guid.NewGuid().ToString(),
                Artist = model.Artist,
                Title = model.Title,
                Description = model.Description,
                CreatorId = currentUserId,
                CreationDate = DateTime.Now,
                PlayCount = 0,
                Charts = new List<Chart>()
            };

            if (file != null)
            {
                await UploadCover(chartset, file);
            }

            if (user != null)
            {
                chartset.Creator = user;
                user.ChartSets.Add(chartset);
                _context.Users.Update(user);
            }

            await _context.ChartSets.AddAsync(chartset);
            await _context.SaveChangesAsync();
        }
        public async Task Download(ChartSetViewModel model, ControllerBase controller)
        {
            if(model.Charts.Count != 0)
            {
                foreach (var chart in model.Charts)
                {
                    await _chartServices.DownloadFileAsync(_chartServices.GetDetailsById(chart.Id), controller);
                };
            };
            
        }
        public async Task<string> UploadCover(ChartSet chartset, IFormFile file)
        {
            var folderPath = Path.Combine(_environment.WebRootPath, $@"ChartSets/{chartset.CreatorId}/{chartset.Id}");
            if(!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            var dbFilePath = $@"ChartSets/{chartset.CreatorId}/{chartset.Id}/{chartset.Id}_setcover{Path.GetExtension(file.FileName)}";
            var filePath = Path.Combine(_environment.WebRootPath, dbFilePath);
            
            if(File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            using var fileStream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(fileStream);
            chartset.CoverPath = $"/{dbFilePath}";
            return dbFilePath;
        }
        public ChartSetViewModel GetDetailsById(string id)
        {
            ChartSetViewModel? model = _context.ChartSets.Select(chartset => new ChartSetViewModel
            {
                Id = chartset.Id,
                CoverPath = chartset.CoverPath,
                Artist = chartset.Artist,
                Title = chartset.Title,
                Description = chartset.Description,
                CreatorId = chartset.CreatorId,
                Creator = chartset.Creator,
                CreationDate = chartset.CreationDate,
                PlayCount = chartset.PlayCount,
                Charts = chartset.Charts
            }).SingleOrDefault(set => set.Id == id);

            return model;
        }
        public async Task UpdateAsync(ChartSetViewModel model, IFormFile file)
        {
            ChartSet? chartset = await _context.ChartSets.FindAsync(model.Id);

            if (chartset != null)
            {
                chartset.Id = model.Id;
                chartset.Artist = model.Artist;
                chartset.Title = model.Title;
                chartset.Description = model.Description;
                chartset.CreatorId = model.CreatorId;
                chartset.Creator = model.Creator;
                chartset.CreationDate = model.CreationDate;
                chartset.PlayCount = model.PlayCount;
                chartset.Charts = model.Charts;

                if (file != null)
                {
                    await UploadCover(chartset, file);
                }

                _context.ChartSets.Update(chartset);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteAsync(ChartSetViewModel model)
        {
            ChartSet? chartset = await _context.ChartSets.FindAsync(model.Id);

            var userFolderPath = Path.Combine(_environment.ContentRootPath, $@"wwwroot\ChartSets\{chartset.CreatorId}");
            var chartsetFolderPath = Path.Combine(_environment.ContentRootPath, $@"wwwroot\ChartSets\{chartset.CreatorId}\{chartset.Id}");
            string[] files = Directory.GetFiles(chartsetFolderPath, "*", SearchOption.AllDirectories);

            if(Directory.Exists(chartsetFolderPath))
            {
                foreach(string file in files)
                {
                    File.Delete(file);
                }
                Directory.Delete(chartsetFolderPath);
            }

            if (Directory.GetFileSystemEntries(userFolderPath).Length == 0)
            {
                Directory.Delete(userFolderPath);
            }

            if (chartset != null)
            {
                _context.ChartSets.Remove(chartset);
                await _context.SaveChangesAsync();
            }
        }
    }
}
