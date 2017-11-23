using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12
{
    class Wrapped:Candy
    {
        //private field
        private string wrap = "plastic";
        //constructor
        public Wrapped(string col):base(col)
        {
            match = 5;
            power = "creates a small explosion when \nmatched with other candies!";
        }
        //mehods
        public override void Display()
        {
            Console.WriteLine($"Boom! Dynamite!");
            Console.WriteLine($"Small explosions occur with the wrapped candy");
        }
        public void PrintWrapped()
        {
            Console.WriteLine($"The {color} candy is a wrapped candy");
            Console.WriteLine($"Material wrapped in: {wrap}");
        }
        //property
        public string Wrap
        {
            get { return wrap; }
            set
            {
                wrap = value;
            }
        }
    }
}
