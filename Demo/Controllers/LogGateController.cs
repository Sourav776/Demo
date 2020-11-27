using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class LogGateController : Controller
    {
        // GET: LogGate
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(string userName)
        {
            Session["userName"] = userName;
            return RedirectToAction("Report","Home");
        }
    }
}