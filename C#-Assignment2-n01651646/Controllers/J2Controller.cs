using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace C__Assignment2_n01651646.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// A two dice game which determines why to roll the value of 10
        /// </summary>
        /// <param name="m">One dice has m sides labelled</param>
        /// <param name="n">Other dice has n sides labelled </param>
        /// <returns>Return the sum of the value of m and n</returns>
        /// <example>
        /// GET: api/J2/DiceGame/6/8 ->There are 5 total ways to get the sum 10.
        /// GET: api/J2/DiceGame/12/4 ->There are 4 ways to get the sum 10.
        /// GET: api/J2/DiceGame/3/3 -> There are 0 ways to get the sum 10.
        /// GET: api/J2/DiceGame/5/5 -> There is 1 way to get the sum 10.
        /// </example>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]

        public string DiceGame(int m, int n)
        {
            int count = getCount(m,n);
            if(count== 1)
            {
                return "There is " + count + " way to get the sum 10.";

            }
            return "There are " + count+ " ways to get the sum 10.";
        }
        
        public int getCount(int m, int n)
        {
            int count = 0;

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i + j == 10)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
