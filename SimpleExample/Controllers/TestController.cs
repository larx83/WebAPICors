using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using CorsExample1.Models;

namespace SimpleExample.Controllers
{
    [Log]
    public class TestController : ApiController
    {
        private readonly Random rnd = new Random();

        public HttpResponseMessage Get()
        {

            var testModel = new TestModel
            {
                TestId = GetId(),
                TestMessage = "Test message",
            };

            return Request.CreateResponse(HttpStatusCode.OK, testModel);
        }

        public HttpResponseMessage Post([FromBody] TestModel testModel)
        {
            var output = new TestModel
            {
                TestId = GetId(),
                TestMessage = testModel.TestMessage,
            };
            return Request.CreateResponse(HttpStatusCode.Created, output);
        }

        public HttpResponseMessage Put([FromBody] TestModel testModel)
        {
            var output = new TestModel
            {
                TestId = GetId(),
                TestMessage = testModel.TestMessage,
            };
            return Request.CreateResponse(HttpStatusCode.OK, output);
        }

        public HttpResponseMessage Delete([FromBody] TestModel testModel)
        {
            var output = new TestModel
            {
                TestId = GetId(),
                TestMessage = "Deleted",
            };
            return Request.CreateResponse(HttpStatusCode.NoContent, output);
        }

        private int GetId()
        {
            return rnd.Next(1, 1000);
        }
    }
}
