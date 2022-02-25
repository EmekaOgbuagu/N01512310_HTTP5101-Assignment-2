using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment_2.Controllers
{
    public class J1Controller : ApiController
    {

        ///<summary>
        /// The is to compute the total number of calories from the choices on the menu.
        /// e.g GET ../api/J1/Menu/4/4/4/4 will return Your total calorie count is 0.
        /// </summary>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]

        public string Menu(int burger, int drink, int side, int dessert)
        {
            string message = "Invalid Message";

            if (burger == 1) //burger choices
            {
                burger = 461; //Cheeseburger
            }
            else if (burger == 2)//burger choices
            {
                burger = 431; //Fish Burger
            }
            else if (burger == 3)//burger choices
            {
                burger = 420; //Veggie Burger
            }
            else if (burger == 4)//burger choices
            {
                burger = 0; //no burger
            }
            else
            {
                var error_msg = message;   
                if( burger <= 0 || burger > 4)// tried to get the api to return an invalid message with this, but i don't think it work.
                {                             // Pls how i do i achieve this?
                    error_msg = message ;
                }
            }
            if (drink == 1) //drink choices
            {
                drink = 130; //Soft Drink
            }
            else if (drink == 2)//drink choices
            {
                drink = 160; //Orange Juice
            }
            else if (drink == 3)//drink choices
            {
                drink = 118; //Milk
            }
            else if (drink == 4)//drink choices
            {
                drink = 0;//no drink
            }
            else
            {
                var error_msg = message;
                if (drink <= 0 || drink > 4)// tried to get the api to return an invalid message with this, but i don't think it work.
                {
                    error_msg = message;// Pls how i do i achieve this?
                }
            }
            if (side == 1) //side order choices
            {
                side = 100; //Fries
            }
            else if (side == 2) //side order choices
            {
                side = 57; //Baked Potato
            }
            else if (side == 3) //side order choices
            {
                side = 70; //Chef Salad
            }
            else if (side == 4) //side order choices
            {
                side = 0; //no side order
            }
            else
            {
                var error_msg = message;
                if (side <= 0 || side > 4) // tried to get the api to return an invalid message with this, but i don't think it work.
                {                          // Pls how i do i achieve this?
                    error_msg = message;
                }
            }
            if (dessert == 1) //dessert choices
            {
                dessert = 167; //Apple Pie
            }                   
            else if (dessert == 2) //dessert choices
            {
                dessert = 266; //Sundae
            }                        
            else if (dessert == 3) //dessert choices
            {
                dessert = 75; //Fruit Cup
            }
            else if (dessert == 4) //dessert choices
            {
                dessert = 0; //No Dessert
            }
            else
            {
                var error_msg = message;
                if (dessert <= 0 || dessert > 4) // tried to get the api to return an invalid message with this, but i don't think it work.
                {                                // Pls how i do i achieve this?
                    error_msg = message;
                }
            }
          
            var total = burger + drink + side + dessert;
            return ("Your total calorie count is " + total.ToString());
            
        }
      

    }
}
