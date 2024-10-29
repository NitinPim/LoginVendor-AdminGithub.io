using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace New25OctLogin.Areas.Admin.Controllers
{
    public class VendorDashboardController : Controller
    {
        // GET: Admin/VendorDashboard
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}