using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.Mvc;
using System.Web.Http;
using Model;

namespace ProjectDemoWebAPI.Controllers
{
    public class TestController : ApiController//ApiController类是走的webApiconfig中的路由
    {
        // GET: Test
        //public ActionResult Index()
        //{
        //    return View();
        //}
        [Route("Test/register")]//特性路由
        [HttpPost]//请求 http://localhost:9001/Test/register
        public string register ([FromBody] Student_T s)
        {
            return s.Name;
        }
        [Route("Test/ceshi")]
        [HttpGet]//请求 http://localhost:9001/Test/ceshi
        public string ceshi(string s)
        {
            return s;
        }
    }
}