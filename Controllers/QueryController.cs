using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMVCApp.Controllers
{
    public class QueryController : Controller
    {
        [Route("Query/{id?}/{name?}")]
        public IActionResult Index(int id, string name)
        {
            ViewData["message"] = "id = " + id + ", name = " + name;
            return View();
        }

    }
}
