using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your final mark: ");
            float mark = float.Parse(Console.ReadLine());

            if (mark >= 90 && mark <= 100)
                Console.WriteLine("Your grade is an A+");
            else if (mark >= 80 && mark <= 89)
                Console.WriteLine("Your grade is A");
            else if (mark >= 70 && mark <= 79)
                Console.WriteLine("Your grade is a B+");
            else if (mark >= 60 && mark <= 69)
                Console.WriteLine("Your grade is a B");
            else if (mark >= 50 && mark <+ 59)
                Console.WriteLine("Your grade is a C");
            else if (mark >= 40 && mark <=49)
                Console.WriteLine("Your grade is a D");
            else if (mark >= 0 && mark <= 39 )
                Console.WriteLine("Your grade os a F");
            else
                Console.WriteLine("There is a problem with the mark you entered");

            Console.WriteLine("Task 3 finished Please press enter to continue.....");
            Console.ReadLine();
            Console.Clear();





    }
}
