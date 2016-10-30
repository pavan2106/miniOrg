using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API1.Controllers
{
    public class DefaultController : ApiController
    {
      [HttpGet]
      public string Hello()
      {
        return "Hello";
      }
    }
}
