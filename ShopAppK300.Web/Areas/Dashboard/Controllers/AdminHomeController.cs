using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopAppK300.Web.Areas.Dashboard.Controllers
{
    public class AdminHomeController : Controller
    {
        // GET: Dashboard/AdminHome
        public ActionResult Index()
        {
            return View();
        }
    }
}