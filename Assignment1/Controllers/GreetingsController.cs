using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingsController : ApiController
    {
        /*<summary> 
           Returns the string “Greetings to {id} people!”
            where id is an integer value.
        </summary>
        <param name = "id" > input value of the user </param>
        <return>
            "string output "Greetings to 3 people"
        </return>
        <examples>
           GET localhost/Greetings/3 => "Greetings to 3 people"
        </example>
        <examples>
           GET localhost/Greetings/6 => "Greetings to 6 people"
        </example>
        <examples>
           GET localhost/Greetings/0 => "Greetings to 0 people"
        </example>
         */
        public string Get(int id)
        {
            string greetings = "Greeting to " + id + " people!";
            return greetings;
        }
    }
}
