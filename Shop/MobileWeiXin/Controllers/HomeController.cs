using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FROST.Utility;
using System.Data;

namespace MobileWeiXin.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            DataTable dt = new DataTable();
            string sql = "SELECT b.cat_name,c.FAreaName,goods_id,a.cat_id,goods_sn,goods_name,goods_number,goods_weight,market_price,shop_price,goods_img,is_real,is_on_sale,is_alone_sale,add_time,is_best,is_new,is_hot,last_update,area_id FROM ecs_goods AS a LEFT JOIN ecs_category AS b ON a.cat_id=b.cat_id LEFT JOIN ecs_sf_area AS c ON a.area_id=c.FAreaId WHERE a.is_on_sale=1";
            dt =DbHelperMySQL.Query(sql).Tables[0];
            ViewBag.dt = dt;
            //dt.Rows[0][].ToString();
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}