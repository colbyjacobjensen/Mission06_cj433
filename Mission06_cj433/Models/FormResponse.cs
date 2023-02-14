using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_cj433.Models
{
    public class FormResponse
    {
        // Required Fields
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public short Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        
        // Optional Fields - Not Required
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25)] // Notes limited to 25 charaacters
        public string Notes { get; set; }
    }
}