using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*---------- Task 1 -----------*/
            /*---- Compering Intergers -----*/

            //Title
            Console.WriteLine("****************************");
            Console.WriteLine("********** Task 1 **********");
            Console.WriteLine("****************************");

            //Get the users input and save them to int variables
            Console.Write("Please inter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter another number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
                Console.WriteLine("the two numbers you entered are equal.");
            else if (num1 > num2)
                Console.WriteLine($"The first number entered, {num1}, is the larger of the two");
            else
                Console.WriteLine($"The second number entered, {num2}, is larger of the two");

            Console.WriteLine("Task 2 finished. Please press enter to continue.....");
            Console.ReadLine();
            Console.Clear();
               

          
        }
    }
}
