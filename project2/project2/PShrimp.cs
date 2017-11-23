using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class PShrimp:Fish
    {
        //child class
        //field
        private Goby partner;
        //constructor
        public PShrimp(Random rand): base(rand)
        {
            partner = null;
            shape = " D-xѺѺX:༄ ";
            price = rand.Next(18, 24);
        }
        //overriden methods
        public override void Swim(int span)
        {
            int start = rgen.Next(0, (span - this.shape.Length));
            if(partner != null)
            {
                partner.MeInWater(start,span);
            }
            this.MeInWater(start, span);
        }
        public override void Print()
        {
            base.Print();
            if(partner != null)
            {
                Console.WriteLine($"carrying partner: {partner.Name}");
            }
        }
        //property
        public Goby Partner
        {
            get { return partner; }
            set { partner = value; }
        }
    }
}
