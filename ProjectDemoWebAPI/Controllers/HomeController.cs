using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
namespace ProjectDemoWebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BLL.JC_CustomerBank jC_CustomerBank_BLL = new BLL.JC_CustomerBank();
            DataTable dt = jC_CustomerBank_BLL.GetList("").Tables[0];
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
