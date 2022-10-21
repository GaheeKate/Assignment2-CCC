using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// This method returns how many games the player(Martha) can plays with the given quaters.
        /// Player should play three machines in turn. Each play costs one quarter. The first machine pays 30 quarters every 35th time it is played
        /// the second machine pays 60 quarters every 100th time it is played
        /// the third pays 9 quartersevery 10th time it is played.
        /// Input the number of quarters should be least one and fewer than 1000
        /// </summary>
        /// <param name="quaters">Integer representing the number of quaters that player have. </param>
        /// <param name="fcount">Integer representing the number of time first machine has been played.</param>
        /// <param name="scount">Integer representing the number of time second machine has been played.</param>
        /// <param name="tcount">Integer representing the number of time third machine has been played.</param>
        /// <example>eg. GET api/J3/SlotMachines/48/3/10/4 -> "Martha plays 66 times before going broke." </example>
        /// <example>eg. GET api/J3/SlotMachines/1001/2/3/4 -> "Wrong input" </example>



        [Route("api/J3/SlotMachines/{quaters}/{fcount}/{scount}/{tcount}")]
        public string GetSlotMachines(int quaters, int fcount, int scount, int tcount)
        {

            int count =0;


            if (1 > quaters || quaters > 1000)
            {
                return "Wrong input";
            }
            else
            {
                while(quaters > 0) { 
                int order = count % 3;
                switch (order)
                {
                    case 0:
                        if (fcount == 35)
                        {
                            quaters = quaters + 30; //claim reward
                            fcount = 0; //reset count
                        }
                        else
                        {
                            quaters = quaters - 1; //pay coin
                            count = count + 1; // user played count up
                            fcount = fcount + 1; //first machine played count up
                         }
                        break;

                    case 1:

                        if (scount == 100)
                        {
                            quaters = quaters + 60;
                            scount = 0;


                        }
                        else
                        {
                            quaters = quaters - 1;
                            count = count + 1;
                            scount = scount + 1;

                        }
                        break;

                    case 2:
                        if (tcount == 10)
                        {
                            quaters = quaters + 9;
                            tcount = 0;

                        }
                        else
                        {
                            quaters = quaters - 1;
                            count = count + 1;
                            tcount = tcount + 1;
                        }
                        break;
                }

                }

                return "Martha plays " + count + " times before going broke.";

            }
        }
    }
}

