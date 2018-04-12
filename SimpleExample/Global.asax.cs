using System.Web;
using System.Web.Http;
using CorsExample1;

namespace SimpleExample
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configuration.Filters.Add(
                new ExceptionFilterAttribute());

        }
    }
}
