using System.ComponentModel.DataAnnotations;

namespace VoHoangHuy.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Author { get; set; }
        [Required]
        public String Content { get; set; }
        public DateTime CreatedAt { get; set; }


    }
}