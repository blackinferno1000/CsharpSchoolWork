using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Goby:Fish
    {
        //child class
        //field
        private PShrimp partner;
        //constructor
        public Goby(string nm, Random rand): base(rand)
        {
            name = nm;
            partner = null;
            shape = " ౨><o))}D> ";
            price = rand.Next(34, 70);
        }
        //methods
        //partners with a pshrimp
        public void ChoosePShrimp(Fish[] fi)
        {
            while(partner == null)
            {
                for(int i = 0; i < fi.Length; i++)
                {
                    if(fi[i] is PShrimp )
                    {
                        PShrimp ps = (PShrimp)fi[i];
                        if (ps.Partner == null)
                        {
                            this.partner = ps;
                            ps.Partner = this;
                            fi[i] = ps;
                            Console.WriteLine($"{name} partnered with shrimp {ps.Name}");
                            break;
                        }
                    }
                }
                break;
            }
        }
        //overriden methods
        public override void Swim(int span)
        {
            if (partner == null)
            {
                base.Swim(span);
            }
        }
        public override void Print()
        {
            base.Print();
            if(partner != null)
            {
                Console.WriteLine($"riding shrimp {partner.Name}");
            }
        }
        //property
        public PShrimp Partner
        {
            get { return partner; }
            set { partner = value; }
        }
    }
}
