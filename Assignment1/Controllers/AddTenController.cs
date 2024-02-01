using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /*<summary> 
            Returns 10 more than the integer input {id}
        </summary>
        <param name = "id" > input value of the user </param>
        <return>
        adds the number
        </return>
        <examples>
            GET localhost/AddTen/21 => 31
        </example>
        <example>
            GET localhost/AddTen/0 => 10
        </example>
        <example>
        GET localhost/AddTen/-9 =>
        </example>         
         */
        public int Get(int id)
        {   
            int addition = 10 + id;
            return addition;
        }
    }
}
