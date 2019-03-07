using System;
using Microsoft.AspNetCore.Mvc;

namespace IntroToDotnetCore.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "Hello World in Index method from Hello Controller";
        }

        [HttpGet("process/{name}")]
        public IActionResult Process(string name)
        {
            ViewBag.Name = name;
            return View();
        }
    }
}