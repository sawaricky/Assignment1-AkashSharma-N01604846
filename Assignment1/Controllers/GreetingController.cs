using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /*<summary> 
           Returns the string “Hello World!”
        </summary>
        <return>
            "string out put on CMD"
        </return>
        <examples>
           POST curl -d "" localhost/Greeting/1
        </example>
         */
        public string Post()
        {
            return "Hello World";
        }

    }
}
