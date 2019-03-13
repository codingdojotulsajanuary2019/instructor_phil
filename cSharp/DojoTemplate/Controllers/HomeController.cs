using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoTemplate.Models;
using DojoTemplate.Factory;

namespace DojoTemplate.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpGet("trails/{trail_id}")]
        public IActionResult Show(long trail_id)
        {
            return View();
        }
    }
}
