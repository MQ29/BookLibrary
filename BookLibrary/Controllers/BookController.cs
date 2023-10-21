using BookLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Controllers
{
    public class BookController : Controller
    {
        static readonly Dictionary<int, Book> _books = new Dictionary<int, Book>();
        static int id = 1;
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if(ModelState.IsValid) 
            {
                book.Id = id++;
                _books.Add(book.Id, book);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
