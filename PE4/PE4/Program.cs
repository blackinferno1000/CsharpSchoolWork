using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4
{
    class Program
    {
        /*
        Sean Lightfoot
        PE4 
        number guesser
        */
        static void Main(string[] args)
        {
            Random rgen = new Random();
            int rand = rgen.Next(0, 101);
            int ans;
            int i = 1;
            Console.WriteLine("Guess the number, you get 8 tries!");
            
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Guess" + i + "?");
                string input = Console.ReadLine();
                int.TryParse(input, out ans);
                if(ans < 0 || ans > 100)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Number not in range of 0-100, enter valid number!");
                    continue;
                }
                if (ans == rand)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Great you guessed it was " + ans + "!");
                    Console.WriteLine("It took you " + i + " turns!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                else if(ans > rand)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Too high!");
                    if (i == 8)
                    {
                        Console.WriteLine("The number was " + rand + "!");
                    }
                }
                else if(ans < rand)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Too low!");
                    if (i == 8)
                    {
                        Console.WriteLine("The number was " + rand + "!");
                    }
                }
                i++;
            }
            while (i <= 8);
        }
    }
}
