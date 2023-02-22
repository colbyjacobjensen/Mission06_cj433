using System.ComponentModel.DataAnnotations;

namespace Mission06_cj433.Models
{
    public class FormResponse // Form Response Table Fields
    {
        // Required Fields
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required(ErrorMessage = "Please enter the movie title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter the movie year")]
        public short Year { get; set; }
        [Required(ErrorMessage = "Please enter the director's name")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Please select a rating")]
        public string Rating { get; set; }
        
        // Optional Fields - Not Required
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25)] // Notes limited to 25 characters
        public string Notes { get; set; }

        // Foreign Key Relationship
        [Required(ErrorMessage = "Please select a category")]
        public int CategoryID { get; set; } // CategoryID FK From Category
        public Category Category { get; set; }
    }
}