using System.Collections.Generic;
using System.Security.Principal;

namespace OOP_Encapsolation_Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions
            #region Q1 : Consider the following class
            //a) Identify at least two problems with this design from an encapsulation perspective.
            /*
                1- Balance is Bublic
                2- withdraw don't Return Balance   
             */
            //b) Describe how you would fix this class to follow proper encapsulation principles.You do not need to write the full code.
            /*
                  1- Balance must be Private instead of Bublic
                  2- withdraw Return Balance   instead of Balance -= amount
             */

            //c) Explain why exposing fields directly(as public) is considered a bad practice in OOP.
             // becouse don't control access and not validate data 

            #endregion
            #endregion
        }
    }
}
