using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace C__Assignment2_n01651646.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// This API returns the remaining number of cupcakes after they have been distributed within the 28 students.  
        /// </summary>
        /// <param name="regular">index number of regular boxes</param>
        /// <param name="drink">index number of small boxes </param>

        /// <returns>Integer returns the number of remainig Cupcakes</returns>
        /// <example>
        /// Get: /api/J1/Party/2/4       -> 0
        /// GET: /api/J1/Party/2/5     -> 3
        /// </example>
        [Route("api/J1/Party/{regular}/{small}")]
        [HttpGet]
        public int Party(int regular, int small)
        {
            if(regular>=0 && small>=0) {
                int totalCupcakes = regular * 8 + small * 3;
                int remainder = totalCupcakes % 28;
                return remainder;
            }
            else return 0;

        }
    }
}
