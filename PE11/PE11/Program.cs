using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE11
{
    /*
     * Sean Lightfoot
     * PE11
     * Quidditch
     */
    class Program
    {
        static void Main(string[] args)
        {
            //objects instantiated
            Random rgen = new Random();
            Seeker ginnie = new Seeker("ginnie",rgen);
            Snitch aSnitch = new Snitch();
            Seeker cho = new Seeker("Cho Chang", rgen);
            
            //quidditch game
            Console.WriteLine("Hello Quidditch!");
            Console.WriteLine("");
            //match proceedings
            Console.WriteLine("Seekers are ready for the match!");
            aSnitch.ReleaseFromBox();
            Console.WriteLine("");
            Console.WriteLine("Seeker Ginnie - get ready to catch the snitch!");
            Console.WriteLine("Seeker Cho - get ready to catch the snitch!");
            Console.WriteLine("");
            ginnie.ChaseSnitch(aSnitch);
            cho.ChaseSnitch(aSnitch);
            Console.WriteLine("");
            //keeps track of winner
            Seeker winner = null;
            //game loop
            while (aSnitch.IsCaught != true)
            {
                ginnie.CatchSnitch();
                //loops stop both from winning and assigns winner
                if(aSnitch.IsCaught == true)
                {
                    winner = ginnie;
                    break;
                }
                else
                {
                    winner = cho;
                }
                cho.CatchSnitch();
            }
            Console.WriteLine("");
            winner.ReleaseSnitch();
            Console.WriteLine("");
            ginnie.QuitGame();
            cho.QuitGame();
            Console.WriteLine("");
            Console.WriteLine($"{winner.Name} won the round!");
            Console.WriteLine("End of Quidditch round!");
        }
    }
}
