using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using PandeyBooks.Models;

namespace PandeyBooks.Controllers
{
    public class BooksController : Controller
    {
        private ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Books
        public IActionResult Index()
        {
            return View(_context.Book.ToList());
        }

        // GET: Books/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Book book = _context.Book.Single(m => m.ID == id);
            if (book == null)
            {
                return HttpNotFound();
            }

            return View(book);
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Book.Add(book);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(book);
        }

        // GET: Books/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Book book = _context.Book.Single(m => m.ID == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // POST: Books/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Update(book);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(book);
        }

        // GET: Books/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Book book = _context.Book.Single(m => m.ID == id);
            if (book == null)
            {
                return HttpNotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Book book = _context.Book.Single(m => m.ID == id);
            _context.Book.Remove(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
