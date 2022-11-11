using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Diagnostics;


namespace Assignment2.Controllers
{
    public class J2sController : ApiController
    {
        /// <summary>
        /// This method returns how many ways you can roll the value of 10
        /// </summary>
        /// <returns> The total ways to the the sum 10 of the two dice.
        /// Major premise: If parameter 'm' or 'n' is bigger than 10 or if the sum of 'm' and 'n' is smaller than 10, returns "There is 0 way to get the sum 10." 
        /// </returns>
        /// <param name="m">positive integer representing the number of sides on the first die</param>
        /// <param name="n">positive integer representing the number of sides on the second die</param>
        /// <example>
        /// GET: api/J2/DiceGame/6/8 -> There are 5 total ways to get the sum 10."
        /// </example>
        /// <example>
        /// GET: api/J2/DiceGame/5/5 -> There is 1 way to get the sum 10."
        /// </example>

        [Route("api/J2s/DiceGame/{m}/{n}")]
        public string GetDiceGame(int m, int n)
        {

            int count = 0;
            int LowestPossible = 0;
            int HighestPossible = 0;
        
            if (m > 10 || n > 10 || (m + n) < 10)

            { return "There is 0 way to get the sum 10."; }

            else
            {
                if (m <= n)
                {
                    for (int mCount = 1; mCount <= m; mCount++)
                    {
                        if (10 - mCount == n)
                        {
                            LowestPossible = mCount;

                        }
                    }
                    HighestPossible = m;
                }
                else if (m > n)
                {
                    for (int nCount = 1; nCount <= n; nCount++)
                    {
                        if (10 - nCount == m)
                        {
                            LowestPossible = nCount;
                        }

                    }
                    HighestPossible = n;
                }



                count = HighestPossible - LowestPossible + 1;


                if (count == 1)
                {
                    return "There is " + count + " way to get the sum 10.";
                }
                else { return "There are " + count + " total ways to get the sum 10."; }



            }

        }
    }


}