using Chartify.Data;
using Chartify.Interfaces;
using Chartify.Models;
using Chartify.ViewModels;
using System;
using System.Runtime.InteropServices;

namespace Chartify.Services
{
    public class ChartServices : IChartServices
    {
        private readonly ApplicationDbContext _context;
        public ChartServices(ApplicationDbContext post)
        {
            _context = post;
        }
        public List<ChartViewModel> GetAll()
        {
            return _context.Charts.Select(chart => new ChartViewModel()
            {
                Id = chart.Id,
                DifficultyName = chart.DifficultyName,
                DifficultyRating = chart.DifficultyRating,
                CreationDate = chart.CreationDate,
                Duration = chart.Duration,
                ObjectCount = chart.ObjectCount,
                FilePath = chart.FilePath,
                ChartSet = chart.ChartSet
            }).ToList();
        }
        public async Task CreateAsync(ChartViewModel model)
        {
            Chart chart = new()
            {
                Id = Guid.NewGuid().ToString(),
                DifficultyName = model.DifficultyName,
                DifficultyRating = model.DifficultyRating,
                CreationDate = model.CreationDate,
                Duration = model.Duration,
                ObjectCount = model.ObjectCount,
                FilePath = model.FilePath,
                ChartSet = model.ChartSet
            };

            await _context.Charts.AddAsync(chart);
            await _context.SaveChangesAsync();
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
                ChartSet = chart.ChartSet
            }).SingleOrDefault(set => set.Id == id);

            return model;
        }
        public async Task UpdateAsync(ChartViewModel model)
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
                chart.FilePath = model.FilePath;
                chart.ChartSet = model.ChartSet;

                _context.Charts.Update(chart);
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteAsync(ChartViewModel model)
        {
            Chart? chart = await _context.Charts.FindAsync(model.Id);

            if(chart != null)
            {
                _context.Charts.Remove(chart);
                await _context.SaveChangesAsync();
            }
        }
    }
}
