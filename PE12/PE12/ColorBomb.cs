using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12
{
    class ColorBomb:Candy
    {
        //private field
        private int boomlvl = 3;
        //constructor
        public ColorBomb(string col) : base(col)
        {
            match = 5;
            power = "removes all candy of chosen color!";
        }
        //methods
        public override void Display()
        {
            Console.WriteLine($"COLORBOMB coming your way!");
            Console.WriteLine($"The color bomb's power {power}");
        }
        public void PrintColorBomb()
        {
            Console.WriteLine($"The {color} candy is a colorbomb candy");
            Console.WriteLine($"Amount of boom: {boomlvl}");
        }
        //property
        public int Boom
        {
            get { return boomlvl; }
            set
            {
                if (value > 0) { boomlvl = value; }
                else { boomlvl = 0; }
            }
        }
    }
}
