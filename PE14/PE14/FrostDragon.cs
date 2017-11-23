using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14
{
    class FrostDragon:Dragon
    {
        //constructor
        public FrostDragon(int sad, string nm, Random rnd): base(sad,nm,rnd)
        {
            sadness = sad;
            name = nm;
            rand = rnd;
        }
        //methods
        public override int Play()
        {
            Console.WriteLine($"{name} breathed frost!");
            int dec = rand.Next(5, 26);
            Console.WriteLine($"sadness decreased by {dec}");
            return dec;
        }
        public override void Display()
        {
            Console.WriteLine($"The frost dragon {name} has {sadness} sadness!");
        }
    }
}
