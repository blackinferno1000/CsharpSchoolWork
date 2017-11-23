using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE17
{
    /*
     * Sean Lightfoot
     * PE17
     * exceptions practice
     */
    class Program
    {
        static void Main(string[] args)
        {
            //loop for input
            string input = "";
            while(input != "quit")
            {
                Console.WriteLine("Enter in some data:");
                input = Console.ReadLine();
                //series of try/catches to validate data type
                try
                {
                    int.Parse(input);
                    Console.WriteLine($"{input} is an int");
                }
                catch
                {
                    Console.WriteLine($"{input} is NOT an int");
                }
                try
                {
                    double.Parse(input);
                    Console.WriteLine($"{input} is a double");
                }
                catch
                {
                    Console.WriteLine($"{input} is NOT a double");
                }
                try
                {
                    Boolean.Parse(input);
                    Console.WriteLine($"{input} is a boolean");
                }
                catch
                {
                    Console.WriteLine($"{input} is NOT a boolean");
                }
                try
                {
                    Char.Parse(input);
                    Console.WriteLine($"{input} is a character");
                }
                catch
                {
                    Console.WriteLine($"{input} is NOT a character");
                }
                Console.WriteLine($"");
            }
        }
    }
}
