using BookManagement_Using_ASP.NET_CORE_Web_App.Data;
using BookManagement_Using_ASP.NET_CORE_Web_App.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement_Using_ASP.NET_CORE_Web_App.Controllers
{
    public class BookController : Controller
    {
        ApplicationDbContext _db;
        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }

        //GET
        public IActionResult Index()
        {
            IEnumerable<Book> objListBooks = _db.books;
            return View(objListBooks);
        }

        //GET
        [Route("~/Add Book")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("~/Add Book")]
        public IActionResult Create(Book obj)
        {
            if (ModelState.IsValid)
            {
                _db.books.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        //Get

        [Route("~/Update Book")]
        public IActionResult Edit(int? id)
        {
            var book = _db.books.Find(id);
            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("~/Update Book")]
        public IActionResult Edit(Book obj)
        {

            if (ModelState.IsValid)
            {
                _db.books.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        //GET
        [Route("~/Remove Book")]
        public IActionResult Delete(int? id)
        {
            var book = _db.books.Find(id);
            return View(book);
        }

        [HttpPost]
        [Route("~/Remove Book")]
        public IActionResult Delete(Book obj)
        {
            _db.books.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


        [Route("~/About This Application")]
        public IActionResult About()
        {
            return View();
        }
    }
}
