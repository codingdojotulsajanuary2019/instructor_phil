using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using IntroToDotnetCore.Models;

namespace IntroToDotnetCore.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            System.Console.WriteLine("---------------------------------------------------");
            int? num = HttpContext.Session.GetInt32("count");
            Console.WriteLine(num);
            if(num == null)
            {
                HttpContext.Session.SetInt32("count", 0);
                List<Author> Authors = new List<Author>()
                {
                    new Author("Dr. Suess"),
                    new Author("Tom Clancy"),
                    new Author("JK Rowling")
                };
                HttpContext.Session.SetObjectAsJson("Authors", Authors);
            }

            string name = HttpContext.Session.GetString("name");
            System.Console.WriteLine(name);

            List<Author> AuthorsAdded = HttpContext.Session.GetObjectFromJson<List<Author>>("Authors");

            // retreive the form data from TempData and add to the Author list
            AuthorsAdded.Add(new Author((string)TempData["name"]));
            HttpContext.Session.SetObjectAsJson("Authors", AuthorsAdded);

            ViewModel ModelToView = new ViewModel()
            {
                Authors = AuthorsAdded
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
            // List<Author> Authors = new List<Author>()
            // {
            //     new Author("Dr. Suess"),
            //     new Author("Tom Clancy"),
            //     new Author("JK Rowling")
            // };

            ViewModel ModelToView = new ViewModel()
            {
                Authors = HttpContext.Session.GetObjectFromJson<List<Author>>("Authors"),
                Author = Author
            };

            if(ModelState.IsValid)
            {
                TempData["name"] = Author.Name;
                HttpContext.Session.SetString("name", Author.Name);
                int? num = HttpContext.Session.GetInt32("count");
                // int num2 = (int)num++;
                System.Console.WriteLine("===========================================");
                // System.Console.WriteLine(num2);
                System.Console.WriteLine("===========================================");
                HttpContext.Session.SetInt32("count", (int)++num);

                return RedirectToAction("Index");
            } else {
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                return View("Index", ModelToView);
            }
        }
    }
}