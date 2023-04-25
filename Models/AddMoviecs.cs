using System;
using System.ComponentModel.DataAnnotations;

namespace Mission6Final.Models
{
    public class AddMovie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required(ErrorMessage = "Enter Title.")]
        public string title { get; set; }
        [Required(ErrorMessage = "Enter year.")]
        public int year { get; set; }
        [Required(ErrorMessage = "Enter Director name.")]
        public string director { get; set; }
        [Required(ErrorMessage = "Enter Rating.")]
        public string rating { get; set; }
        [Required(ErrorMessage = "This is required")]
        public bool edited { get; set; }
        public string lentTo { get; set; }
        // this restricts the characters to not exceed 25 characters
        [MaxLength(25)]
        public string notes { get; set; }
    }
}

