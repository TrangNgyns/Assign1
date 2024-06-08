using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign1.Controllers
{
    public class SquaredController : ApiController
    {
        /// <summary>
        /// Receives a number, returns the number squared up
        /// <param name="id">Number to be entered</param>
        /// </summary>
        /// <returns>
        /// Square of {id}
        /// </returns>
        /// <example>
        // Get api/Squared/2 -> 4
        // Get api/Squared/-2 -> 4
        // Get api/Squared/10 -> 100
        /// </example>

        [HttpGet]
        [Route("api/Squared/{id}")]
        public int Square(int id)
        {
            int squared = id * id;
            return squared;
        }
    }
}
