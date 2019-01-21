using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Controllers
{
    public class HoleController : Controller
    {
        [HttpGet("/")]
        public IActionResult Root()
        {
            return View();
        }
        [HttpGet("/Masters/Hole/{number}")]
        public IActionResult Hole(Int32 number)
        {
            if (number == 2 || number == 3 || number == 7)
            {
                return View("Hole" + number);
            }
            return View("UnderConstruction");
        }
    }
}
