using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMVCApp.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Hello! this is sample message!";
            return View();
        }


        [HttpPost]
        public IActionResult Form()
        {
            ViewData["Message"] = Request.Form["msg"];
            return View("Index");
        }
    }
}
