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
        public DateTime CreationDate { get; set; }
        public int PlayCount { get; set; }

        //
        public string CreatorId { get; set; }
        [ForeignKey("CreatorId")]
        public virtual User Creator { get; set; }
        public List<Chart> Charts { get; set; }
    }
}
