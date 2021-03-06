using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMVCApp.Controllers
{
    public class FormMultiSelectController : Controller
    {
        public List<string> list;

        /// <summary>
        /// コンストラクターです
        /// </summary>
        public FormMultiSelectController()
        {
            list = new List<string>();
            list.Add("Japan");
            list.Add("USA");
            list.Add("UK");
        }

        public IActionResult Index()
        {
            ViewData["message"] = "Select item:";
            ViewData["list"] = new string[] { };  // ☆
            ViewData["listdata"] = list;
            return View();
        }

        [HttpPost]
        public IActionResult Form()
        {
            string[] res = (string[])Request.Form["list"];
            string msg = "※";
            foreach (var item in res)
            {
                msg += "「" + item + "」";
            }
            ViewData["message"] = msg + " selected.";
            ViewData["list"] = Request.Form["list"];
            ViewData["listdata"] = list;
            return View("Index");
        }
    }
}
