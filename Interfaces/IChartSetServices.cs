using Chartify.Models;
using Chartify.ViewModels;

namespace Chartify.Interfaces
{
    public interface IChartSetServices
    {
        List<ChartSetViewModel> GetAll();
        Task CreateAsync(ChartSetViewModel model, IFormFile file, string currentUserId);
        Task<string> UploadCover(ChartSetViewModel model, IFormFile file);
        ChartSetViewModel GetDetailsById(string id);
        Task UpdateAsync(ChartSetViewModel model, IFormFile file);
        Task DeleteAsync(ChartSetViewModel model);
    }
}
