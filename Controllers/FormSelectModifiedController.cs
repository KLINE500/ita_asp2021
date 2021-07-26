using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMVCApp.Controllers
{
    public class FormSelectModifiedController : Controller
    {
        public List<SelectListItem> list;

        /// <summary>
        /// コンストラクターです
        /// </summary>
        public FormSelectModifiedController()
        {
            list = new List<SelectListItem>();
            SelectListItem i1 = new SelectListItem("Japan", "Japan");
            list.Add(i1);
            SelectListItem i2 = new SelectListItem("USA", "USA");
            list.Add(i2);
            SelectListItem i3 = new SelectListItem("UK", "UK");
            list.Add(i3);
            //いちいち変数名を考えるのが面倒くさいので
            //以下のように２行をまとめて書くことも可能です
            list.Add(new SelectListItem("FR", "FR"));

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
