using BusinessRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel.VMModel;

namespace New25OctLogin.Controllers
{
    public class ProjectController : Controller
    {
        Status status = new Status();
        Repository repository;
        // GET: ProjectController


        public ProjectController()
        {
            repository = new Repository();
        }


        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(VMRequest vmrequest)
        {
            VMLogin vmlogin = repository.CheckLogin(vmrequest);

            if (vmlogin.IsLoginSuccess)
            {
                if(vmlogin.UserRoleId == 1)
                {
                    return Redirect("/Admin/Dashboard/Dashboard");
                }
                else if(vmlogin.UserRoleId == 2)
                {
                    return Redirect("/Admin/VendorDashboard/Index");
                }
                else
                {
                    TempData["Message"] = "Incorrect username or password.";    
                    return RedirectToAction("Login", "Project" );
                }
            }
            else
            {
                TempData["Message"] = "Incorrect username or password.";
                return RedirectToAction("Login", "Project");
            }
            
        }

       

        

        public JsonResult AddLoginDetails(VMLogin vmlogin)
        {
            return Json(repository.AddLoginDetails(vmlogin));
        }
    }
}