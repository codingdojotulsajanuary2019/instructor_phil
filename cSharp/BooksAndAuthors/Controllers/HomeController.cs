using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BooksAndAuthors.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksAndAuthors.Controllers
{
    public class HomeController : Controller
    {

        private Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            // List<Author> CAuthors = _context.Authors.Include(a => a.Wrote).ToList();

            // foreach(Author a in CAuthors)
            // {
            //     Console.WriteLine(a);
            // }

            IndexView DataToIndex = new IndexView() {
                Authors = _context.Authors
                    .Include(a => a.Wrote)
                    .ThenInclude(b => b.Publications)
                    .ToList(),
                Books = _context.Books
                    .Include(b => b.Publications)
                    .ThenInclude(p => p.Publisher)
                .ToList(),
                Publishers = _context.Publishers.ToList()
            };

            return View(DataToIndex);
        }

        [HttpPost("authors")]
        public IActionResult AddAuthor(Author Author)
        {
            if(ModelState.IsValid)
            {
                _context.Add(Author);
                _context.SaveChanges();

                return RedirectToAction("Index");
            } else {
                IndexView DataToIndex = new IndexView() {
                Authors = _context.Authors
                    .Include(a => a.Wrote)
                    .ThenInclude(b => b.Publications)
                    .ToList(),
                Books = _context.Books
                    .Include(b => b.Publications)
                    .ThenInclude(p => p.Publisher)
                .ToList(),
                Publishers = _context.Publishers.ToList()
            };
                return View("Index", DataToIndex);
            }
        }

        [HttpPost("books")]
        public IActionResult AddBook(Book Book)
        {
            if(ModelState.IsValid)
            {
                _context.Add(Book);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                IndexView DataToIndex = new IndexView() {
                Authors = _context.Authors
                    .Include(a => a.Wrote)
                    .ThenInclude(b => b.Publications)
                    .ToList(),
                Books = _context.Books
                    .Include(b => b.Publications)
                    .ThenInclude(p => p.Publisher)
                .ToList(),
                Publishers = _context.Publishers.ToList()
            };
                return View("Index", DataToIndex);
            }
        }

        [HttpPost("publishers")]
        public IActionResult AddPublisher(Publisher Publisher)
        {
            if(ModelState.IsValid)
            {
                _context.Add(Publisher);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                IndexView DataToIndex = new IndexView() {
                Authors = _context.Authors
                    .Include(a => a.Wrote)
                    .ThenInclude(b => b.Publications)
                    .ToList(),
                Books = _context.Books
                    .Include(b => b.Publications)
                    .ThenInclude(p => p.Publisher)
                .ToList(),
                Publishers = _context.Publishers.ToList()
            };
                return View("Index", DataToIndex);
            }
        }

        [HttpPost("publication")]
        public IActionResult CreatePublication(Publication Publication)
        {
            if(ModelState.IsValid)
            {
                _context.Add(Publication);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                IndexView DataToIndex = new IndexView() {
                Authors = _context.Authors
                    .Include(a => a.Wrote)
                    .ThenInclude(b => b.Publications)
                    .ToList(),
                Books = _context.Books
                    .Include(b => b.Publications)
                    .ThenInclude(p => p.Publisher)
                .ToList(),
                Publishers = _context.Publishers.ToList()
            };
                return View("Index", DataToIndex);
            }
        }
    }
}
