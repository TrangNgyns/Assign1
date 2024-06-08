using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Receives a number, returns that number multiplied by 3 then plus 5 and divided by 2. Finally squared up.
        /// </summary>
        /// <example>
        // Get api/NumberMachine/10 -> ((10 * 3 + 5) / 2 )^2
        /// </example>
         
        [HttpGet]
        [Route("api/NumberMachine/{id}")]
        public int Number(int id)
        {
            return ((10 * id + 5) / 2) ^ 2;
        }
    }
}
