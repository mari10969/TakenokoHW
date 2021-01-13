using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyHobbyWebsite.Models;

namespace MyHobbyWebsite.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Root()
        {
            return View();
        }
        [HttpGet("/")]
        public IActionResult ONEOKROCK()
        {
            return View();
        }
        [HttpGet("/")]
        public IActionResult MYFIRSTSTORY()
        {
            return View();

        }
        [HttpGet("/")]
        public IActionResult COLDRAIN()
        {
            return View();
        }
    }
}
