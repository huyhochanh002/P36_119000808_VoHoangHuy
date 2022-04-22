using System.ComponentModel.DataAnnotations;

namespace VoHoangHuy.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public String? Name { get; set; } 
        [Required]
        
        public String? Content { get; set; }
        public IEnumerable<News>? News { get; set;}


    }
}