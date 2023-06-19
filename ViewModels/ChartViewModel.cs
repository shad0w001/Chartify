using Chartify.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chartify.ViewModels
{
    public class ChartViewModel
    {
        public string Id { get; set; }
        public string DifficultyName { get; set; }
        public double DifficultyRating { get; set; }
        public DateTime CreationDate { get; set; }
        public int ObjectCount { get; set; }
        public string FilePath { get; set; }
        public string ChartSetId { get; set; }
        public ChartSet ChartSet { get; set; }
    }
}
