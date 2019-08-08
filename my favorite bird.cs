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
            Console.WriteLine("Try and guess my fav bird...");
            Console.Write("Please enter a type of bird");
            string guess = Console.ReadLine().ToLower();

            Console.WriteLine("\nTry and guess which of these is my favorite bird Eagle / flamingo /owl / peacock");
            Console.WriteLine(guess);

            switch (guess)
            {
                case "eagle":
                    Console.WriteLine("Yay, you guessed correct...");
                    break;

                case "flamingos":
                    Console.WriteLine("sorry wrong answer");
                    break;

                case "owl":
                    Console.WriteLine("Nah wrong answer");
                    break;

                case "peacock":
                    Console.WriteLine("You are wrong again");
                    break;

                default:
                    Console.WriteLine("Your way off...");
                    break;

            }

                
                    
           


                


            
          

              
                

        }
    }
}
