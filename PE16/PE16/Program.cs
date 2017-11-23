using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE16
{
    /*
     Sean Lightfoot
     PE16
     Dictionary practice
     */
    class Program
    {
        static void Main(string[] args)
        {
            //object instantiated
            Dictionary<string, string> dict = new Dictionary<string, string>();
            //dictionary filled
            dict.Add("Kingsmen", "british spies go on crazy adventures");
            dict.Add("Deadpool", "zany mercenary turns into superhuman with vengeance");
            dict.Add("It", "clown tortures neighborhood kids to consume their fear");
            //loop for commands to be used
            Console.WriteLine($"Enter a command");
            string input = "";
            while(input != "quit")
            {
                input = Console.ReadLine();
                if(input == "add")
                {
                    Console.WriteLine($"movie title?");
                    string in1 = Console.ReadLine();
                    Console.WriteLine($"description?");
                    string in2 = Console.ReadLine();
                    dict.Add(in1, in2);
                    Console.WriteLine($"{in1} added to dictionary!");
                }
                if(input == "print")
                {
                    Console.WriteLine($"movie title?");
                    string in1 = Console.ReadLine();
                    if (dict.ContainsKey(in1))
                    {
                        Console.WriteLine(dict[in1]);
                    }
                    else
                    {
                        Console.WriteLine("ERROR movie not available to print!");
                    }
                }
            }
            Console.WriteLine($"Thank you for using movie descriptor!");
        }
    }
}
