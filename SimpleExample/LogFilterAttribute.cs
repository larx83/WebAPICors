using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace SimpleExample
{
    public class LogAttribute : Attribute, IActionFilter
    {
        public Task<HttpResponseMessage> ExecuteActionFilterAsync(HttpActionContext actionContext, 
            CancellationToken cancellationToken, 
            Func<Task<HttpResponseMessage>> continuation)
        {
            var actionDescriptorActionName = actionContext.ActionDescriptor.ActionName;
            Trace.WriteLine(actionDescriptorActionName);

            File.AppendAllLines(@"C:\Logs\WebApiCors.log", new []{actionDescriptorActionName});

            var result = continuation();

            result.Wait();

            return result;
        }

        public bool AllowMultiple
        {
            get { return true; }
        }
    }
}