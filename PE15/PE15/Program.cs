using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE15
{
    /*
     Sean Lightfoot
     PE15
     List practice
     */
    class Program
    {
        static void Main(string[] args)
        {
            //object instantiated
            ArtInventory art = new ArtInventory();
            //strings added
            art.AddToInventory("Pencil");
            art.AddToInventory("Sketchbook");
            art.AddToInventory("Brush");
            //loop for commands to take place
            Console.WriteLine($"What action do you want to take?");
            string input = "";
            while (input != "quit")
            {
                input = Console.ReadLine();
                if(input == "print")
                {
                    art.PrintInventory();
                }
                if(input == "count")
                {
                    art.ListCount();
                }
                if(input == "remove")
                {
                    art.RemoveFromInventory();
                }
                if(input == "add")
                {
                    art.AddToInventory();
                }
                else
                {
                    Console.WriteLine("enter valid command");
                }
            }
        }
    }
}
