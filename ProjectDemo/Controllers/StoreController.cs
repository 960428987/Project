using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectDemo.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            var albums = new List<Album>();
            for(int i = 0;i < 10; i++)
            {
                albums.Add(new Album { title = "procut " + i});
            }
            ViewBag.Message = "292";
            ViewBag.sss = albums;
            return View();
        }

        public string Browse(string id)
        {
            //<script>window.location='http://hacker.example.com'</script>
            string message = "store.browse,genre = " + id;
            //string message1 = HttpUtility.HtmlEncode("store.browse,genre = " + genre);
            return message;
        }
        public string Details()
        {
            return "hellow from store.details";
        }
        //public string Index()
        //{
        //    return "hellow from store.index";
        //}
    }
    public class Album
    {
        public string title { set; get; }
    }
}