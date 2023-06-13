using Chartify.ViewModels;

namespace Chartify.Interfaces
{
    public interface IChartServices
    {
        List<ChartViewModel> GetAll();
        Task CreateAsync(ChartViewModel model);
        ChartViewModel GetDetailsById(string id);
        Task UpdateAsync(ChartViewModel model);
        Task DeleteAsync(ChartViewModel model);
    }
}
