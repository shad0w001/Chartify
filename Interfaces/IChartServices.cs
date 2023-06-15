using Chartify.Models;
using Chartify.ViewModels;

namespace Chartify.Interfaces
{
    public interface IChartServices
    {
        List<ChartViewModel> GetAll();
        Task CreateAsync(ChartViewModel model, IFormFile file);
        Task<string> UploadFile(Chart chart, IFormFile file);
        ChartViewModel GetDetailsById(string id);
        Task UpdateAsync(ChartViewModel model, IFormFile file);
        Task DeleteAsync(ChartViewModel model);
    }
}
