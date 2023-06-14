using Chartify.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chartify.ViewModels
{
    public class ChartSetViewModel
    {
        [Key]
        public string Id { get; set; }
        public string CoverPath { get; set; }

        [Display(Name = "Artist Name")]
        [Required(ErrorMessage = "Artist Name is required")]
        public string Artist { get; set; }

        [Display(Name = "Song Title")]
        [Required(ErrorMessage = "Song Title is required")]
        public string Title { get; set; }
        public string Description { get; set; }
        public string CreatorId { get; set; }
        public virtual User Creator { get; set; }

        [Display(Name = "Creation Date")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Play Count")]
        public int PlayCount { get; set; }
        public List<Chart> Charts { get; set; } = new List<Chart>();
    }
}
