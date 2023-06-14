using System.ComponentModel.DataAnnotations.Schema;

namespace Chartify.Models
{
    public class Chart
    {
        public string Id { get; set; }
        public string DifficultyName { get; set; }
        public double DifficultyRating { get; set; }
        public DateTime CreationDate { get; set; }
        public TimeSpan Duration { get; set; }
        public int ObjectCount { get; set; }
        public string FilePath { get; set; }

        //
        public string ChartSetId { get; set; }
        [ForeignKey("ChartSetId")]
        public ChartSet ChartSet { get; set; }

    }
}
