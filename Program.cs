/* NAME: SUHAGAN MOSTAHID
 * CLASS: NET-23
 * SCHOOL: CHAS ACADEMY*/



using System;
namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] arg)
        {
            int x = 10; //Taking a variable with value 10.
            //if else statement to check whether the value of the variable bigger than, smaller than or equal to 10.
            if (x > 10)
                Console.WriteLine("number is bigger");
            else if (x == 10)
                Console.WriteLine("number is equal.");
            else
                Console.WriteLine("Oj. number is smaller");




            Console.WriteLine("what is your name?"); //Asking users to input their name.
            string namn = Console.ReadLine(); //Here 'Console.ReadLine()' will take input from the user and store the value in the variable 'namn'.
            Console.WriteLine("Hej "+ namn+"!");

            //creating for loop to print out all the values of 'x' from 0 to 10.
            for (int i = 0; i <=x; i++) 
            {
                Console.WriteLine(i);

            }



        }
    }
}