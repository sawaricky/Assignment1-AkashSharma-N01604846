using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class SquareController : ApiController
    {
       /*
           <summary> 
              square of the integer input {id}.
           </summary>
           <param name = "id" > input value of the user </param>
           <return>
                Returns the square of the integer input {id}.
           </return>
           <examples>
               GET localhost/Square/2 => 4
           </example>
           <example>
               GET localhost/Square/-2 => 4
           </example>
           <example>
               GET localhost/Square/10 => 100
           </example>         
        */
        public int Get(int id)
        {
            int squareNumber = id * id;
            return squareNumber;
        }
    }
}
