using System;
using System.ComponentModel.DataAnnotations;

namespace quicknote.Models
{
    public class Note
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]        
        public string Content { get; set; }

        [Required]
        public DateTime DateCreation { get; set; }
    }
}