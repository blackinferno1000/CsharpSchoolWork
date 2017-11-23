using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    /*
     * Sean Lightfoot
     * Project 2
     * Aquarium exercise
     */
    class Program
    {
        static void Main(string[] args)
        {
            //random object and fish array instantiated
            Random rgen = new Random();
            Console.WriteLine("Sean Lightfoot: Aquarium");
            Fish[] fishies = StockAquarium(17, rgen);
            //loop for knifefish broadcast
            foreach (Fish fin in fishies)
            {
                if(fin is Knifefish)
                {
                    Knifefish kn = (Knifefish)fin;
                    kn.Broadcast(fishies);
                    break;
                }
            }
            //fish partnered
            PartnerGoby(fishies);
            //aquarium shown
            Console.WriteLine("The full aquarium:");
            foreach(Fish fin in fishies)
            {
                fin.Swim(50);
            }
            //fish info and total price shown
            Console.WriteLine("*****Stock details*****");
            double total = 0;
            foreach(Fish fin in fishies)
            {
                fin.Print();
                total += fin.Price;
            }
            Console.WriteLine($"Total starting cost: {total}");
        }

        //static methods
        //fills a fish array with random fish types
        static Fish[] StockAquarium(int numfish, Random rand)
        {
            Fish[] fishies = new Fish[numfish];
            int gene;
            Console.WriteLine("*****Stocking the aquariumS!*****");
            for(int i = 0; i< fishies.Length; i++)
            {
                gene = rand.Next(0, 4);
                switch (gene)
                {
                    case 0:
                        fishies[i] = new PShrimp(rand);
                        break;
                    case 1:
                        fishies[i] = new Goby("Goby " + i, rand);
                        break;
                    case 2:
                        fishies[i] = new Knifefish("Ghost Knife " + i, rand);
                        break;
                    case 3:
                        fishies[i] = new Fish(rand);
                        break;
                }
            }
            return fishies;
        }
        //partners gobies to pshrimp
        static void PartnerGoby(Fish[] fi)
        {
            Console.WriteLine("Attempting to partner goby fish...");
            foreach(Fish fin in fi)
            {
                if(fin is Goby)
                {
                    Goby gob = (Goby)fin;
                    gob.ChoosePShrimp(fi);
                }
            }
        }
    }
}
