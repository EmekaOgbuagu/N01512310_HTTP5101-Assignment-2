using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment_2.Controllers
{
  
       public class J2Controller : ApiController // Hi Christine i am abit overwhelmed please give me until 3rd of march to push my updated code.
    {
        [HttpGet]
        //[Route("api/J2/DiceGame/{m}/{n}")]
        [Route("api/J2/DiceGame/{m}")]  //using this to test. 
        public string DiceGame (int m /*, int n*/)
        {
            /*for (int n_dice = 0; n_dice < n - 1; n_dice++)
             {
                 int first_dice = n_dice;
                 for (int m_dice = first_dice + 1; m_dice < m; m_dice++)
                 {
                     int second_dice = m;
                     if (first_dice + second_dice == 10)
                     {
                         return {first_dice, second_dice};
                 }
             }*/
            int start = 1;
            string message = "";
            int counter = start;
            

            while (counter <= m )
            {
                message = message + counter;
                counter = counter + 1;
            }
            return message;
            // return ("I want to see where " + m + n + "lead");


        }
    }
}
