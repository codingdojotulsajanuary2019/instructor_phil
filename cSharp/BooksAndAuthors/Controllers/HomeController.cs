using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BooksAndAuthors.Models;

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

            IndexView DataToIndex = new IndexView() {Authors = _context.Authors.ToList()};

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
                IndexView DataToIndex = new IndexView() {Authors = _context.Authors.ToList()};
                return View("Index", DataToIndex);
            }
        }

    }
}
