using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using IntroToDotnetCore.Models;

namespace IntroToDotnetCore.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            List<Author> Authors = new List<Author>()
            {
                new Author("Dr. Suess"),
                new Author("Tom Clancy"),
                new Author("JK Rowling")
            };
            // retreive the form data from TempData and add to the Author list
            Authors.Add(new Author((string)TempData["name"]));

            ViewModel ModelToView = new ViewModel()
            {
                Authors = Authors
            };

            return View(ModelToView);
        }

        [HttpGet("process")]
        public IActionResult Process()
        {
            // ViewBag.Name = name;
            return View();
        }

        [HttpPost("authors")]
        public IActionResult AddAuthor(Author Author)
        {
            Console.WriteLine(Author);
            Console.WriteLine(Author.Name);
            List<Author> Authors = new List<Author>()
            {
                new Author("Dr. Suess"),
                new Author("Tom Clancy"),
                new Author("JK Rowling")
            };

            ViewModel ModelToView = new ViewModel()
            {
                Authors = Authors,
                Author = Author
            };

            if(ModelState.IsValid)
            {
                TempData["name"] = Author.Name;
                return RedirectToAction("Index");
            } else {
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                return View("Index", ModelToView);
            }
        }
    }
}