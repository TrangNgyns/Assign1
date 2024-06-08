using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Charging client $5.50 / FN (14 days) + 13% HST. Receives number of days since beginning, returns 3 strings describing the total cost.
        /// <param name="id">number of days so far </param>
        /// 
        /// intended Logic:
        /// HST = (5.50 * X) * 13 / 100
        /// if (0 <= id < 14) -> X = 1
        /// else if (14 <= id < 28) -> X = 2
        /// so on so forth...
        /// meaning: id / 14 = +int = X -> REVISED so that day 0 already costed the price of 1 fortnight: X = (id + 14) / 14
        /// 
        /// Need vars for: X (fortnight num), fortnight spent, HST, total
        /// 
        /// "FN" >number of fortnight elapsed
        /// "FNspent" >cost of fortnight(s)
        /// "HST" >HST tax hahaha
        /// "Total" >sum of FNspent & HST
        /// "FNmessage" >first line about hosting costs pre-tax
        /// "HSTmessage" >second line about separate HST charge
        /// "Totalmessage" >last line about the total charge
        /// </summary>
        /// 
        /// <example>
        // GET api/HostingCost/0 ->
        // "1 fortnights at %5.50/FN = $5.50 CAD"
        // "HST 13% = $0.72 CAD"
        // "Total = $6.22 CAD"

        // GET api/HostingCost/21 ->
        // "1 fortnights at %5.50/FN = $5.50 CAD"
        // "HST 13% = $0.72 CAD"
        // "Total = $6.22 CAD"
        /// </example>

        [HttpGet]
        [Route("api/HostingCost/{id}")]
        public string Host(int id)
        { 
            int FN = (id + 14) / 14;
            double FNspent = 5.50 * FN;
            double HSTfull = FNspent * 13 / 100;
            double HST = Math.Round(HSTfull, 2);
            double Total = FNspent + HST;
            string FNmessage = FN + " fortnights at $5.50/FN = " + FNspent + " CAD";
            string HSTmessage = "HST 13% = " + HST + " CAD";
            string Totalmessage = "Total = " + Total + " CAD";
            return FNmessage + HSTmessage + Totalmessage;
        }
        /// <summary>
        /// Troubles:
        /// Unsure how to have "line breaks" or string outputs on three separate lines
        /// Unsure how to have FNspent write int with the double 00 decimal (eg. 11 CAD as 11.00 CAD)
        /// </summary>
    }
}
