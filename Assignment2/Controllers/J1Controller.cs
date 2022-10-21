using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{

    public class J1Controller : ApiController
    {
        /// <summary>
        /// Compute the total Calories of the meal
        /// </summary>
        /// <returns>The total calories of the meal choices</returns>
        /// <param name="burger">Integer representing the index burger choice</param>
        /// <param name="drink">Integer representing the index drink choice</param>
        /// <param name="side">Integer representing the index side choice</param>
        /// <param name="dessert">Integer representing the index dessert choice</param>
        /// <example>eg. GET api/J1/Menu/4/4/4/4 -> "Your total calorie count is 0" </example>
        /// <example>eg. GET api/J1/Menu/1/2/3/4 -> "Your total calorie count is 691" </example>
        /// <example>eg. GET api/J1/Menu/5/2/3/4 -> "Wrong input" </example>


        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string GetMenu(int burger, int drink, int side, int dessert)
        {
            int b = 0; 
            switch (burger)
            {
                case 1:
                    b = 461;
                    // Cheeseburger (461 Calories)
                    break;
                case 2:
                    b = 431;
                    // Fish Burger (431 Calories)
                    break;
                case 3:
                    b = 420;
                    // Veggie Burger (420 Calories)
                    break;
                case 4:
                    // no burger
                    break;
                default:
                    return "Wrong input";
                    // wrong input
            }
            int d = 0;
            switch (drink)
            {
                case 1:
                    d = 130;
                    // Soft Drink (130 Calories)
                    break;
                case 2:
                    d = 160;
                    // Orange Juice (160 Calories)
                    break;
                case 3:
                    d = 118;
                    // Milk (118 Calories)
                    break;
                case 4:
                    d = 0;
                    // no drink
                    break;
                default:
                    return "Wrong input";
                    // wrong input
            }
            int s = 0;
            switch (side)
            {
                case 1:
                    s = 100;
                    // Fries (100 Calories)
                    break;
                case 2:
                    s = 57;
                    // Baked Potato (57 Calories)
                    break;
                case 3:
                    s = 70;
                    // Chef Salad (70 Calories)
                    break;
                case 4:
                    // no side order
                    break;
                default:
                    return "Wrong input";
                    // wrong input
            }
            int de = 0;
            switch (dessert)
            {
                case 1:
                    de = 167;
                    // Apple Pie (167 Calories)
                    break;
                case 2:
                    de = 266;
                    // Sundae (266 Calories)
                    break;
                case 3:
                    de = 75;
                    // Fruit Cup (75 Calories)
                    break;
                case 4:
                    // No Dessert
                    break;
                default:
                    return "Wrong input";
                    // wrong input
            }
            int total = b + d + s + de;
            return "Your total calorie count is " + total;
        }

        





    }
}
