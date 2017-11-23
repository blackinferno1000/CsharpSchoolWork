using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14
{
    /*
    Sean Lightfoot
    PE14
    Abstract classes practice
    */
    class Program
    {
        static void Main(string[] args)
        {
            //objects instantiated
            Random rgen = new Random();
            FireDragon blaze = new FireDragon(100, "Inferno", rgen);
            FrostDragon frost = new FrostDragon(120, "Blizz", rgen);
            //objects displayed
            blaze.Display();
            frost.Display();
            //dragons playing
            while(blaze.Sadness > 0 || frost.Sadness > 0)
            {
                int fire = blaze.Play();
                frost.Sadness -= fire;
                int blizzard = frost.Play();
                blaze.Sadness -= blizzard;
                blaze.Display();
                frost.Display();
            }
            Console.WriteLine($"{blaze.Name} and {frost.Name} are now companions.");
        }
    }
}
