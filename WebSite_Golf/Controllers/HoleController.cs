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
            if (IsUnderConstructionHole(number) == true)
            {
                return View("UnderConstruction");
            }
            return View("Hole" + number.ToString("00"));
        }
        public static Boolean IsUnderConstructionHole(Int32 number)
        {
            if (number < 15)
            {
                return false;
            }
            return true;
        }
    }
}
