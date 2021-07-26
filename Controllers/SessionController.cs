using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMVCApp.Controllers
{
    public class SessionController : Controller
    {
        [HttpGet("Session/{id?}/{name?}")]
        public IActionResult Index(int id, string name)
        {
            ViewData["message"] = "※セッションにIDとNameを保存しました。";
            HttpContext.Session.SetInt32("id", id);
            HttpContext.Session.SetString("name", name);
            return View();
        }


        [HttpGet]
        public IActionResult Other()
        {
            ViewData["id"] = HttpContext.Session.GetInt32("id");
            ViewData["name"] = HttpContext.Session.GetString("name");
            ViewData["message"] = "保存されたセッションの値を表示します。";
            return View("Index");
        }
    }
}
