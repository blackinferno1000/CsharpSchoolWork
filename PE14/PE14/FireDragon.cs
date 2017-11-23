using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14
{
    class FireDragon: Dragon
    {
        //constructor
        public FireDragon(int sad,string nm, Random rnd): base(sad,nm,rnd)
        {
            sadness = sad;
            name = nm;
            rand = rnd;
        }
        //methods
        public override int Play()
        {
            Console.WriteLine($"{name} breathed fire!");
            int dec = rand.Next(10, 21);
            Console.WriteLine($"sadness decreased by {dec}");
            return dec;
        }
        public override void Display()
        {
            Console.WriteLine($"The fire dragon {name} has {sadness} sadness!");
        }
    }
}
