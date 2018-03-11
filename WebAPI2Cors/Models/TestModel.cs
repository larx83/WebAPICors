using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI2Cors.Models
{
    public class TestModel
    {
        public string AppName { get; set; } = "Custom Cors Attribute";
        public int TestId { get; set; }
        public string TestMessage { get; set; }
    }
}