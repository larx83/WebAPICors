using System.Net;
using System.Net.Http;
using System.Web.Http;
using CorsExample1.Models;

namespace CorsExample1.Controllers
{
    public class TestController : ApiController
    {
        public HttpResponseMessage Get()
        {
            var testModel = new TestModel{
                TestId = 1,
                TestMessage = "Test message",
            };
            return Request.CreateResponse(HttpStatusCode.OK, testModel);
        }

        public HttpResponseMessage Post([FromBody] TestModel testModel)
        {
            var output = new TestModel{
                TestId = testModel.TestId,
                TestMessage = testModel.TestMessage + "Simple Expample",
            };  
            return Request.CreateResponse(HttpStatusCode.OK, output);
        }
    }
}
