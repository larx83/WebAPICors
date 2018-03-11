﻿using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI2Cors;
using WebAPI2Cors.Models;

namespace CustomCorsAttribute.Controllers
{
    [EnableCorsCustom]
    public class TestController : ApiController
    {
        public HttpResponseMessage Get()
        {
            var testModel = new TestModel{
                TestId = 1,
                TestMessage = "Test Message",
            };
            return Request.CreateResponse(HttpStatusCode.OK, testModel);
        }

        public HttpResponseMessage Post([FromBody] TestModel testModel)
        {
            var output = new TestModel{
                TestId = testModel.TestId,
                TestMessage = testModel.TestMessage,
            };  
            return Request.CreateResponse(HttpStatusCode.OK, output);
        }
    }
}
