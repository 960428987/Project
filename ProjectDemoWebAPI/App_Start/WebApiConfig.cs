using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ProjectDemoWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            //关于webApi路由配置学习看：https://www.cnblogs.com/landeanfen/p/5501490.html#_label0


            // Web API 配置和服务

            // Web API 路由
            config.MapHttpAttributeRoutes();//启用webapi特性路由

            //RouteParameter.Optional 设置参数为可选
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",//我加了一个Action，设置url规则为api/controller + /action(方法)+参数
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
