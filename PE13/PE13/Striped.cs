using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE13
{
    class Striped:Candy
    {
        //private field
        private int stripes = 3;
        //constructor
        public Striped(string col) : base(col)
        {
            match = 4;
            power = "clears whole row or column of candy!";
        }
        //methods
        public override void Display()
        {
            Console.WriteLine($"Stripey McStriperson, at your service/n I have {stripes} stripes!");
            Console.WriteLine($"I get rid of all candies in the same row or column");
        }
        public void PrintStriped()
        {
            Console.WriteLine($"The {color} candy is a striped candy");
            Console.WriteLine($"Has {stripes} stripes");
        }
        //property
        public int Stripes
        {
            get { return stripes; }
            set
            {
                if (value > 0) { stripes = value; }
                else { stripes = 3; }
            }
        }
    }
}
