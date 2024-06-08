using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Post type! Returns the string "Hello World!"
        /// </summary>
        /// <example>
        // Post api/Greeting -> "Hello World!"
        /// </example>

        [HttpPost]
        [Route("api/Greeting")]
        public string Greeting()
        {
            return "Hello World!";
        }

        /// <summary>
        /// Returns string "Greetings to {number} people!"
        /// <param name="id">number to be entered</param>
        /// </summary>
        /// <example>
        // Get api/Greeting/3 -> "Greetings to 3 people!"
        // Get api/Greeting/6 -> "Greetings to 6 people!"
        /// </example>

        [HttpGet]
        [Route("api/Greeting/{id}")]
        public string Greeting(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
