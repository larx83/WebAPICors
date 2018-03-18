using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace CorsExample1
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

        }
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            var corsEnabled = HttpContext.Current.Request.Params.Get("enable");
            if (corsEnabled == "true")
            {
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Credentials", "true");

                //if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
                //{
                //    HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
                //    HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept, Cache-control, pragma");
                //    HttpContext.Current.Response.AddHeader("Access-Control-Max-Age", "1728000");
                //    HttpContext.Current.Response.End();
                //}

                
            }
        }

        protected void Application_EndRequest(Object sender, EventArgs e)
        {
            var resp = HttpContext.Current.Response;
        }

        protected void Application_PreSendRequestHeaders(Object sender, EventArgs e)
        {
            var resp = HttpContext.Current.Response;
        }

        protected void Application_PreSendRequestContent(Object sender, EventArgs e)
        {
            var resp = HttpContext.Current.Response;
        }
    }
}
