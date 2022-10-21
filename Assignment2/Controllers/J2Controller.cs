using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// This method returns how many ways you can roll the value of 10
        /// </summary>
        /// <returns> The total ways to the the sum 10 of the two dice.
        /// </returns>
        /// <param name="m">positive integer representing the number of sides on the first die</param>
        /// <param name="n">positive integer representing the number of sides on the second die</param>
        /// <example>
        /// GET: api/J2/DiceGame/6/8 -> There are 5 total ways to get the sum 10."
        /// </example>
        /// <example>
        /// GET: api/J2/DiceGame/5/5 -> There is 1 way to get the sum 10."
        /// </example>

        [Route("api/J2/DiceGame/{m}/{n}")]
        public string GetDiceGame(int m, int n)
        {

            int count = 0;

            for(int mCount=1; mCount <= m; mCount++){
                for(int nCount=1; nCount <= n; nCount++){
                    if (mCount + nCount == 10){
                     count = count + 1;}
                }
            }

            if (count == 1){
                return "There is " + count + " way to get the sum 10.";}
            else {return "There are " + count + " total ways to get the sum 10."; }

        }






    }
}

