using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileWeiXin.Controllers
{
    public class NavbarController : Controller
    {
        // GET: Navbar
        [AuthenticationController]
        public ActionResult Index()
        {
            return View();
        }
    }
}