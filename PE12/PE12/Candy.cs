using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12
{
    class Candy
    {
        //parent fields
        protected string color;
        protected int match;
        protected string power;
        //parent constructor
        public Candy(string col)
        {
            color = col;
            match = 0;
            power = "Match 3 of these candies to make in a row to earn points!";
            Console.WriteLine($"Made a {color} candy");
        }
        //parent methods
        public void Print()
        {
            Console.WriteLine($"The {color} candy requires {match} matched candies to spawn");
            Console.WriteLine($"{color}'s special power: {power}");
        }

        public virtual void Display()
        {
            Console.WriteLine($"This candy's color is {color}");
            Console.WriteLine(this.power);
        }
        //parent properties
        public string Color
        {
            get { return color; }
        }
        public int Match
        {
            get { return match; }
            set { if (value > 0) { match = value; }
                else { match = match; }
            }
        }
        public string Power
        {
            get { return power; }
            set { power = value; }
        }
    }
}
