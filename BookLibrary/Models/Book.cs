using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace BookLibrary.Models
{
    public class Book
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        public string? ISBN { get; set; }
        [Range(0, 2023)]
        public int? PublicationDate { get; set; } 
        public string? Publisher { get; set; }
    }
}
