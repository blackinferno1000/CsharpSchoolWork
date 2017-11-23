using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Describe your potion!");
            Console.WriteLine("Color?");
            string col = Console.ReadLine();
            Console.WriteLine("Strength?");
            string stre = Console.ReadLine();
            int str;
            int.TryParse(stre, out str);
            Console.WriteLine("Name?");
            string nm = Console.ReadLine();
            Console.WriteLine("Use?");
            string us = Console.ReadLine();
            Console.WriteLine("Doses?");
            string dos = Console.ReadLine();
            int dose;
            int.TryParse(dos, out dose);
            Console.WriteLine("");

            Potion pot = new Potion(col,str,nm,us,dose);
            Console.WriteLine("");
            Potion def = new Potion();
            Console.WriteLine("");
            pot.PrintPotion();
            Console.WriteLine("");
            def.PrintPotion();
            Console.WriteLine("");
            Console.WriteLine("fire used on wild rat!");
            pot.UsePotion();
            Console.WriteLine("");
            pot.PrintPotion();
            Console.WriteLine("");
            Console.WriteLine("New Strength?");
            string stren = Console.ReadLine();
            int strn;
            int.TryParse(stren, out strn);
            pot.ChangeStrength(strn);
            Console.WriteLine("");
            Console.WriteLine("New Use?");
            string use = Console.ReadLine();
            pot.ChangeUsage(use);
            Console.WriteLine("");
            pot.PrintPotion();
        }
    }
}
