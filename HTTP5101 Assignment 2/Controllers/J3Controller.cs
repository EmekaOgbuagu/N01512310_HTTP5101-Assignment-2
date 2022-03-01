using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment_2.Controllers
{
    public class J3Controller : ApiController
    {
         ///<summary>
        ///Declare the letters on each keypad number as a array.
        ///put a condition to store the number of times the property of an array i picked.  
        ///</summary>
        [HttpGet]
        [Route("api/J2/words/'string'")]

        public string words(string[] );

        string keypad = [];
               keypad[0] = [2];
               keypad[1] = [3];
               keypad[2] = [4];
               keypad[3] = [5];
               keypad[4] = [6];
               keypad[5] = [7];
               keypad[6] = [8];
               keypad[7] = [9];
           
              keypad[0][2] = ['a','b','c']
              keypad[0][3] = ['d','e','f']
              keypad[0][4] = ['g','h','i']
              keypad[0][5] = ['j','k','l']
              keypad[0][6] = ['m','n','o']
              keypad[0][7] = ['p','q','r','s']
              keypad[0][8] = ['t','u','v']
              keypad[0][2] = ['w','x','y','z']

              // Can't figure out how to input the string and output the number of times each condition will be met. 

      



    } 
}

