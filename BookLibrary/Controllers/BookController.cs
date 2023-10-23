using BookLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace BookLibrary.Controllers
{
    public class BookController : Controller
    {
        static readonly Dictionary<int, Book> _books = new Dictionary<int, Book>();
        static int id = 1;
        public IActionResult Index()
        {
            return View(_books);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book model)
        {
            if (ModelState.IsValid) 
            {
                model.Id = id++;
                _books.Add(model.Id, model);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_books[id]);
        }

        [HttpPost]
        public IActionResult Update(Book model)
        {
            if (ModelState.IsValid)
            {
                _books[model.Id] = model;
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_books[id]);
        }

        [HttpPost]
        public IActionResult Delete(Book model)
        {
            _books.Remove(model.Id);
            return RedirectToAction("Index");
        }


        public IActionResult Details(Book model)
        {
            return View(_books);
        }
    }
}
