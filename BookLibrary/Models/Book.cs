using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace BookLibrary.Models
{
    public class Book
    {
        [HiddenInput]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        [Required(ErrorMessage = "You have to type ISBN number.")]
        public string ISBN { get; set; }
        [Range(0, 2023)]
        public int? PublicationDate { get; set; } 
        public string? Publisher { get; set; }
    }
}
