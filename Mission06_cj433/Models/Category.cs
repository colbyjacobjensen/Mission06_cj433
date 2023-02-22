using System.ComponentModel.DataAnnotations;

namespace Mission06_cj433.Models
{
    public class Category // Category Table Fields
    {
        [Key]
        [Required]
        public int CategoryID { get; set; } // Category ID Key Linked to FormResponse
        [Required]
        public string CategoryName { get; set; }
    }
}