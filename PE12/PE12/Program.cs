using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12
{
    /*
     Sean Lightfoot
     PE12
     Overriden methods
    */
    class Program
    {
        static void Main(string[] args)
        {
            //objects instantiated
            Regular reg = new Regular("red");
            Striped str = new Striped("blue");
            ColorBomb bomb = new ColorBomb("rainbow");
            Wrapped wrap = new Wrapped("green");
            //reg.Print();
            //reg.PrintRegular();
            //str.Print();
            //str.PrintStriped();
            //bomb.Print();
            //bomb.PrintColorBomb();
            //wrap.Print();
            //wrap.PrintWrapped();
            //objects displayed
            reg.Display();
            str.Display();
            bomb.Display();
            wrap.Display();
        }
    }
}
