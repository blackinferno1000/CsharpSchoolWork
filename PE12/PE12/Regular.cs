using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12
{
    class Regular:Candy
    {
        //private field
        private int shinelvl = 5;
        //constructor
        public Regular(string col) : base(col)
        {
            match = 0;
            power = "Match 4 or more of these to earn points!";
        }
        //methods
        public override void Display()
        {
            Console.WriteLine($"I may be boring, but I get the job done");
            Console.WriteLine($"When 4 or more regular {color} candies are matched, special candies spawn");
        }
        public void PrintRegular()
        {
            Console.WriteLine($"The {color} candy is a regular candy");
            Console.WriteLine($"Shine, is at {shinelvl}");
        }
        //property
        public int Shine
        {
            get { return shinelvl; }
            set { if(value > 0) { shinelvl = value; }
                else { shinelvl = 0; }
            }
        }
    }
}
