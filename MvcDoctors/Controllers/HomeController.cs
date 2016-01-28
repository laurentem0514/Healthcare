using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDoctors.Controllers
{
    public class HomeController : Controller
    {
        // GET /
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }
    }
}