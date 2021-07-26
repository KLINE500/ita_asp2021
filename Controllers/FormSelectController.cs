using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMVCApp.Controllers
{
    public class FormSelectController : Controller
    {
        public List<string> list;

        /// <summary>
        /// コンストラクターです
        /// </summary>
        public FormSelectController()
        {
            list = new List<string>();
            list.Add("Japan");
            list.Add("USA");
            list.Add("UK");
        }

        public IActionResult Index()
        {
            ViewData["message"] = "Select item:";
            ViewData["list"] = "";
            ViewData["listdata"] = list;
            return View();
        }

        [HttpPost]
        public IActionResult Form()
        {
            ViewData["message"] = '"' + Request.Form["list"] + '"' + " selected.";
            ViewData["list"] = Request.Form["list"];
            ViewData["listdata"] = list;
            return View("Index");
        }
    }
}
