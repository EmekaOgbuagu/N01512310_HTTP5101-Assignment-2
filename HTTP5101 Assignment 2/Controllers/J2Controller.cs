using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment_2.Controllers
{

    public class J2Controller : ApiController
    ///<summary>
    ///Get a loop to run all the sides of the first die.
    ///After running the first number from the first die, let it be a constant to run the all the condition for the second die in a loop.
    ///then store the combination of the first loop constant and all the conditions from the second loop that is equal to 10.
    ///store the numbers of times i + j ==10 condition is met with the sum variable.
    ///repeat this until all the conditions from the first loop has been compared with all the conditions from the second loop.
    ///Return sum to get the number of time m + n = 10
    ///...example http://localhost:56021/api/J2/DiceGame/6/8 = 5.
    ///</summary>
    {
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n) 
        {
            var NoOfWays = 0;

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i + j == 10)
                    {
                        NoOfWays = NoOfWays++; // this will happen when m + n == 10
                    }
                }
            }

            return NoOfWays.ToString(); // this will oouput the number of times m + n == 10
        }
    }
}
