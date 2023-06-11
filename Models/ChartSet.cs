using System.ComponentModel.DataAnnotations.Schema;

namespace Chartify.Models
{
    public class ChartSet
    {
        public string Id { get; set; }
        public string CoverPath { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        [ForeignKey("AspNetUsers")]
        public string CreatorId { get; set; }
        public virtual User Creator { get; set; }
        public DateTime CreationDate { get; set; }
        public int Status { get; set; }
        public int PlayCount { get; set; }
        public List<Chart> Charts { get; set; } = new List<Chart>();
    }
}
