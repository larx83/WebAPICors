using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using SimpleExample;

namespace CorsExample1
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configuration.Filters.Add(
                new ExceptionFilterAttribute());

        }
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            var request = HttpContext.Current.Request;
            var response = HttpContext.Current.Response;

            var corsEnabled = request.Params.Get("enable");

            if (corsEnabled == "true")
            {
                
                response.AddHeader("Access-Control-Allow-Origin", "*");
                response.AddHeader("Access-Control-Allow-Credentials", "true");

                //if (request.HttpMethod == "OPTIONS")
                //{
                //    response.AddHeader("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
                //    response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept, Cache-control, pragma");
                //    response.AddHeader("Access-Control-Max-Age", "1728000");
                //    response.End();
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
