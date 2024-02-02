using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /*
            <summary> 
            Create a method which has an input {id}, 
            and applies four mathematical operations to it.
            </summary>
            <param name =id> input form user</param>
            <param name = FortNightCost> cost per 1 fornights </param>
            <param name = HST> the sales added tax </param>
            <param name = TotalFortnights> outputs integer value of fornights </param>
            <param name = Cost> cost for total fortnights </param>
            <param name = TotalHST> tax for total fortnights </param>
            <param name = Total> cost inclusive of tax for total fortnights </param>
            <param name = Output1> out put for cost of fortnight(s)  </param>
            <param name = Output2> out put for cost of tax for the fortnight(s)  </param>
            <param name = Output3> out put for the Total cost   </param>
            <return>
               shows the output of output1, output2 and output3 strings
            </return>
            <examples>
               GET .../HostingCost/0 => 1 fortnights at $5.5/FN = 5.5 CAD HST 13% = 0.715 CAD Total = $6.215 CAD
            </example>
            <examples>
              GET .../HostingCost/14 => 2 fortnights at $5.5/FN = 11 CAD HST 13% = 1.43 CAD Total = $12.43 CAD 
            </example>
            <examples>
             GET .../HostingCost/21 =>  2 fortnights at $5.5/FN = 11 CAD HST 13% = 1.43 CAD Total = $12.43 CAD 
            </example>
            <examples>
               GET .../HostingCost/28 =>  3 fortnights at $5.5/FN = 16.5 CAD HST 13% = 2.145 CAD Total = $18.645 CAD
            </example>
         */
        public string Get(int id)
        {

            double FortNightCost = 5.50;
            double HST = 0.13;

            int TotalFortnights = (id / 14) + 1;
            double Cost = TotalFortnights * FortNightCost;
            double TotalHST = Cost * HST;
            double Total = TotalHST + Cost;
            string Output1 = TotalFortnights.ToString() + " fortnights at $" + FortNightCost + "/FN" +
                " = " + Cost + " CAD ";
            string Output2 = "HST 13% = " + TotalHST.ToString() + " CAD ";
            string Output3 = "Total = $" + Total + " CAD ";
            return Output1 + "\n" + Output2 + "\n"+ Output3;


            //logic test
            /*    double total = (id / 14.0) + 1;
                   double cost = total * 5.5;
                   double hstvalue = cost * 0.13;
                   double finaltotal = cost + hstvalue;
                   return finaltotal;*/
        }

    }
}
