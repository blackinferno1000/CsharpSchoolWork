using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE13
{
    class Cast
    {
        //field
        private Random rgen;
        //constructor
        public Cast()
        {
            rgen = new Random();
        }
        //method
        public Candy AssignCandy(string color)
        {
            int assign = rgen.Next(0, 101);
            if(assign >= 0 && assign <= 40)
            {
                Regular reg = new Regular(color);
                return reg;
            }
            else if(assign >= 41 && assign <= 65)
            {
                ColorBomb bomb = new ColorBomb(color);
                return bomb;
            }
            else if(assign >=66 && assign <= 85)
            {
                Striped str = new Striped(color);
                return str;
            }
            else if(assign >= 86 && assign <= 100)
            {
                Wrapped wrap = new Wrapped(color);
                return wrap;
            }
            Regular def = new Regular(color);
            return def;
        }

    }
}
