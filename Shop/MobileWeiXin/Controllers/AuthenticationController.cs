using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MobileWeiXin.Controllers {
    public class AuthenticationController : ActionFilterAttribute {
        public override void OnActionExecuting(ActionExecutingContext filterContext) {
            if (filterContext.HttpContext.Session["loginUser"] == null)
                filterContext.Result = new RedirectResult("/Management/Login");
            //filterContext.Result = new RedirectToRouteResult("/Login", new RouteValueDictionary { { "from", filterContext.HttpContext.Request.Url.ToString() } });
            base.OnActionExecuting(filterContext);
        }
    }
}