using System.ComponentModel.DataAnnotations;

namespace PathBinder.Models
{
    public class Document
    {
        public int Id { get; set; }

        [Required] 
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;
    }
}
