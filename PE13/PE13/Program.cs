using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE13
{
   /*Sean Lightfoot
     PE13
     Polymorphism practice
     */
    class Program
    {
        static void Main(string[] args)
        {
            //objects instantiated
            //Regular reg = new Regular("red");
            //Striped str = new Striped("blue");
            //ColorBomb bomb = new ColorBomb("rainbow");
            //Wrapped wrap = new Wrapped("green");
            //reg.Print();
            //reg.PrintRegular();
            //str.Print();
            //str.PrintStriped();
            //bomb.Print();
            //bomb.PrintColorBomb();
            //wrap.Print();
            //wrap.PrintWrapped();
            //objects displayed
            //reg.Display();
            //str.Display();
            //bomb.Display();
            //wrap.Display();
            //cast object
            Cast cas = new Cast();
            //loop to get and print candies
            int i = 0;
            while(i < 10)
            {
                Candy candy;
                candy = cas.AssignCandy("Red");
                candy.Display();
                Console.WriteLine("---Changing---");
                //casting candy to proper type
                if (candy is Regular)
                {
                    Regular reg = ((Regular)candy);
                    reg.Shine = 15;
                    reg.Display();
                }
                else if (candy is ColorBomb)
                {
                    ColorBomb bomb = ((ColorBomb)candy);
                    bomb.Boom = 25;
                    bomb.Display();
                }
                else if (candy is Striped)
                {
                    Striped str = ((Striped)candy);
                    str.Stripes = 5;
                    str.Display();
                }
                else if (candy is Wrapped)
                {
                    Wrapped wrap = ((Wrapped)candy);
                    wrap.Wrap = "paper";
                    wrap.Display();
                }
                i++;
            }
        }
    }
}
