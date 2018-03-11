using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using CorsExample1.Models;

namespace SimpleExample.Controllers
{
    public class TestController : ApiController
    {
        public HttpResponseMessage Get()
        {
            var testModel = new TestModel{
                TestId = 1,
                TestMessage = "Test message sdf",
            };

            return Request.CreateResponse(HttpStatusCode.OK, testModel);
        }

        public HttpResponseMessage Post([FromBody] TestModel testModel)
        {
                var output = new TestModel{
                TestId = testModel.TestId,
                TestMessage = testModel.TestMessage,
            };  
            return Request.CreateResponse(HttpStatusCode.Created, output);
        }

        public string Options()
        {
            return null; // HTTP 200 response with empty body
        }
    }
}
