using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE7
{
    class Potion
    {
        public string Color;
        public double Strength;
        public string Name;
        public string Usage;
        public int Doses;

        public Potion()
        {
            Name = "Potion";
            Strength = 50;
            Color = "Colorless";
            Usage = "Cast on a person";
            Doses = 10;
        }
        public Potion(string co,double str,string nm,string us,int dos)
        {
            Color = co;
            Strength = str;
            Name = nm;
            Usage = us;
            Doses = dos;
        }
        
        public void UsePotion()
        {
            if (this.Doses == 0)
            {
                Console.WriteLine("Potion has no doses left!");

            }
            else
            {
                this.Doses--;
                Console.WriteLine("Using potion... " + Doses + " left!");
            }
        }

        public void PrintPotion()
        {
            Console.WriteLine("---"+ Name+"'s Stats---");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Strength: "+ Strength);
            Console.WriteLine("Color: "+ Color);
            Console.WriteLine("Usage: "+ Usage);
            Console.WriteLine("Doses: "+ Doses);
        }

        public void ChangeStrength(int str)
        {
            this.Strength = str;
        }

        public void ChangeUsage(string us)
        {
            this.Usage = us;
        }
    }
}
