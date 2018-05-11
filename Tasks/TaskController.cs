using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Tasks
{
    public class TaskController : ApiController
    {
        public string Get()
        {
            return "Hello World!!";
        }
    }
}