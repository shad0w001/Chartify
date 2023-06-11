using System.ComponentModel.DataAnnotations.Schema;

namespace Chartify.Models
{
    public class ChartsOfSets
    {
        [ForeignKey("Chart")]
        public string ChartId { get; set; }
        public Chart Chart { get; set; }

        [ForeignKey("ChartSet")]
        public string ChartSetId { get; set; }
        public ChartSet ChartSet { get; set; }
    }
}
