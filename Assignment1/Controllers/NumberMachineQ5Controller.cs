using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class NumberMachineQ5Controller : ApiController
    {
        /*        
        <summary> 
             method which has an input {id}, and applies four mathematical operations to it.
          </summary>
          <param name = "id" > input value of the user </param>
          <param name = "product" > Multiplcation of the id by 2</param>
           <param name = "subtraction" > subtraction of the id by 2</param>
         <param name = "division" > division of the id by 2</param>
          <return>
               Returns four mathematical operations to it.
          </return>
          <examples>
              GET localhost/NumberMachineQ5/10 => The product = 20 The sum = 12 The Subtraction is = 8 The division is = 5
          </example>
          <example>
              GET localhost/NumberMachineQ5/10 => The product = -10 The sum = -3 The Subtraction is = -7 The division is = -2
          </example>
          <example>
               GET localhost/NumberMachineQ5/30 => The product = 60 The sum = 32 The Subtraction is = 28 The division is = 15
          </example>         
           */
        public string Get(int id)
        {
            int product = id * 2;
            int Addition = id + 2;
            int substraction = id - 2;
            int division = id / 2;

            return "The product = " + product + " The sum = " 
                + Addition + " The Subtraction is = " + substraction + " The division is = " + division;

        }

    }
}
