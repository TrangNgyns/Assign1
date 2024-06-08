using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Receives a number, returns the number in addition with 10
        /// <param name="id">Number to be entered</param>
        /// </summary>
        /// <returns>
        /// {id} plus ten
        /// </returns>
        /// <example>
        // Get api/AddTen/21 -> 31
        // Get api/AddTen/0 -> 10
        // Get api/AddTen/-9 -> 1
        /// </example>

        [HttpGet]
        [Route("api/AddTen/{id}")]
        public int AddTen(int id)
        {
            int sum = id + 10;
            return sum;
        }
    }
}
