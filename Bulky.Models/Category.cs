using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Bulky.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; } //Primary Key
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(30, ErrorMessage = "Can't add more that 30 characters as name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Range of display order must be in range 1-100")]
        public int DisplayOrder { get; set; }
    }
}
