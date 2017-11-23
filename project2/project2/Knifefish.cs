using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Knifefish:Fish
    {
        //child class
        //constructor
        public Knifefish(string nm,Random rand): base(rand)
        {
            name = nm;
            shape = " <W||><t ";
            price = rand.Next(20, 51);
        }
        //methods
        //broadcasts to other knifefish
        public void Broadcast(Fish[] fi)
        {
            int i = 0;
            foreach(Fish fin in fi)
            {
                if(fin is Knifefish)
                {
                    if(fin.Name != this.name)
                    {
                        Console.Write($"{fin.Name}, ");
                        i++;
                    }
                }
            }
            if (i > 0)
            {
                Console.WriteLine($"and the NSA heard the bzzzzz broadcast by {this.Name}");
            }
        }
    }
}
