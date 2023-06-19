using Chartify.ViewModels;

namespace Chartify.Models
{
    public class SearchViewModel
    {
        public string SearchCriteria { get; set; }
        public IEnumerable<ChartSetViewModel> ChartSetResults { get; set; }
        public IEnumerable<User> UserResults { get; set; }
    }
}
