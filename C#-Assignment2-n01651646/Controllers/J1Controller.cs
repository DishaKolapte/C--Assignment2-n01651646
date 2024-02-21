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
        /// This API returns the total calories consumed according to the menu.  
        /// </summary>
        /// <param name="burger">index burger choice</param>
        /// <param name="drink">index drink choice</param>
        /// <param name="side">index side order choice</param>
        /// <param name="dessert">index dessert choice</param>
        /// <returns>String message giving the computed total Calories of the meal</returns>
        /// <example>
        /// Get: /api/J1/Menu/4/4/4/4        -> total calorie count is 0
        /// GET: /api/J1/Menu/1/2/3/4       ->total calorie count is 691
        /// </example>
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            List<int> burgerCal = new List<int> { 461, 431, 420, 0 };
            List<int> drinkCal = new List<int> { 130, 160, 118, 0 };
            List<int> sideCal = new List<int> { 100, 57, 70, 0 };
            List<int> dessertCal = new List<int> { 167, 266, 75, 0 };

            int total = burgerCal[burger - 1] + drinkCal[drink - 1] + dessertCal[dessert-1] + sideCal[side-1];

            

            return "The total Calorie count is " + total;
        }
    }
}
