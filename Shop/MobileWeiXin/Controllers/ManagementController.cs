using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileWeiXin.Controllers
{
    public class ManagementController : Controller
    {
        // GET: Management
        [AuthenticationController]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login() {
            if (!string.IsNullOrEmpty(Request["loginPassword"])) {
                Session["loginUser"] = Request["loginPassword"];
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}