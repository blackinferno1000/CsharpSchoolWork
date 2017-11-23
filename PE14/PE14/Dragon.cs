using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14
{
    public abstract class Dragon
    {
        //fields
        protected int sadness;
        protected string name;
        protected Random rand;
        //constructor
        public Dragon(int sad, string nm, Random rnd)
        {
            sadness = sad;
            name = nm;
            rand = rnd;
        }
        //methods
        public abstract int Play();
        public abstract void Display();
        //properties
        public int Sadness
        {
            get { return sadness; }
            set
            {
                if (value < 0) { sadness = 0; }
                else
                {
                    sadness = value;
                }
            }
        }
        public string Name
        {
            get { return name; }
        }
    }
}
