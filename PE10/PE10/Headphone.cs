using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE10
{
    class Headphone
    {
        //fields
        private string name;
        private double price;
        //constructor
        public Headphone(string nm,double pr)
        {
            name = nm;
            price = pr;
        }
        //method
        public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine($"Price: {price}");
            Console.WriteLine("");
        }
        //getters
        public String Name
        {
            get { return name; }
        }
        public double Price
        {
            get { return price; }
        }
    }
}
