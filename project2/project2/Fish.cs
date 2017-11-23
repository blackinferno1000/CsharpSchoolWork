using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Fish
    {
        //parent class
        //protected fields
        protected Random rgen;
        protected string name;
        protected string shape;
        protected double price;
        protected ConsoleColor color;
        //constructor
        public Fish(Random rand)
        {
            rgen = rand;
            name = rgen.Next(1, 101).ToString();
            shape = " <C>< ";
            price = 5;
            ConsoleColor[] colors = ((ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor)));
            color = colors[rgen.Next(0, colors.Length)];
        }
        //methods
        //shows fish position in water
        public void MeInWater(int start, int span)
        {
            int i = 0;
            while(i < start)
            {
                Console.Write($"~");
                i++;
            }
            i = 0;
            Console.ForegroundColor = this.color;
            Console.Write($"{this.shape}");
            Console.ForegroundColor = ConsoleColor.White;
            while(i < span - (start + this.shape.Length))
            {
                Console.Write($"~");
                i++;
            }
            Console.WriteLine("");
        }
        //works in tandum with MeInWater method
        public virtual void Swim(int span)
        {
            int start = rgen.Next(0, span - (this.shape.Length));
            MeInWater(start, span);
        }
        //prints info of fish
        public virtual void Print()
        {
            Console.WriteLine($"Fish {this.name} : {this.shape} {this.color} for ${this.price}");
        }
        //properties
        public string Name
        {
            get { return name; }
        }
        public double Price
        {
            get { return price; }
        }
    }
}
