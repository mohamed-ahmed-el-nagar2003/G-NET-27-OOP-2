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

            #region Q2
            //Q02 :
            //What is the difference between a field and a property in C#?
            /*
             field : 1-direct data storege  2- no validation  3- break encapsolation
             property : 1- control access 2- can validate 3- enforces encapsolation
             */
            //Can a property contain logic?
            /*
             Yes in computed property 
            */
            //Give an example of a read-only property that returns a calculated value.
            /*
            Student st01 = new Student();
            st01.Age = 22;
            Console.WriteLine(st01.AgeAfter_10_years);
            */




            #endregion

            #region Q_3

            // a) What is `this[int index]` called? Explain its purpose.
            /*
             Is called indexer
            help us to trate with object as collection to access any item 
             */

            // b) What happens if someone writes `register[10] = "Ali";` ? How would you make the indexer safer?

            /*
             Throw exseption 
            validate index if bigger than lengh Return "no size"
             */
            //  c) Can a class have more than one indexer? If yes, give an example of when that would be useful.
            /*
             yes
            when want to access item from more than way such as ID or Name 
             */

            #endregion

            #region Q_04
            //a) What does the `static` keyword mean on `TotalOrders`? How is it different from the `Item` field?
            /*
             it is shared to all objects belong to class 
            but `Item` field belong to object
             */

            // b) Can a static method inside `Order` access the `Item` field directly? Why or why not?
            /*
             No becouse only belong to class don't trate with any object 
             */

            #endregion


            #endregion
        }
    }
}
