using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE11
{
    class Seeker
    {
        private Snitch myTarget;
        private string name;
        Random seekerRgen;

        public Seeker(string nm,Random rg)
        {
            myTarget = null;
            name = nm;
            seekerRgen = rg;
        }

        public string Name
        {
            get { return name; }
        }

        public void ChaseSnitch(Snitch p_target)
        {
            Console.WriteLine($"{this.Name} chasing snitch");
            myTarget = p_target;
        }

        public bool CatchSnitch()
        {
            Console.WriteLine($"{this.name} attempts to catch the snitch");
            int rand = seekerRgen.Next(1, 11);
            if (rand == 10)
            {
                Console.WriteLine($"{this.name} caught snitch");
                myTarget.CaughtBySeeker();
                return true;
            }
            
            return false;
        }

        public void ReleaseSnitch()
        {
            Console.WriteLine($"{this.name} released snitch");
            myTarget.PlaceInBox();
            myTarget = null; //seeker done with snitch
        }

        public void QuitGame()
        {
            myTarget = null;
            Console.WriteLine($"{this.name} quits playing Quidditch");
        }
    }
}
