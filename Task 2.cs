using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 7;

            Console.Write("Try and guess my number from 1 to10: ");
            int guess = int.Parse(Console.ReadLine());

            if (guess == number)
                Console.WriteLine("You got it, tu meke alright");
            else if(guess > number)
                Console.WriteLine("Sorry your guess was to high");
            else
                Console.WriteLine("Sorry your guess wae to low");

            Console.WriteLine("Task 2 finished. Please press enter tpo continue.....");

            Console.ReadLine();
            Console.Clear();
        }
    }
}
