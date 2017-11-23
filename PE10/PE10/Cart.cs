using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE10
{
    class Cart
    {
        //field of array of objects
        private Headphone[] items;
        //constructors
        public Cart()
        {
            items = new Headphone[3];
            items[0] = new Headphone("Beats", 200);
            items[1] = new Headphone("Bose", 400);
            items[2] = new Headphone("Sennheiser", 300);
        }
        public Cart(int num)
        {
            items = new Headphone[num];
            Console.WriteLine("");
            Console.WriteLine("--Input name and price of items below--");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("Item name?");
                string nm = Console.ReadLine();
                Console.WriteLine("Item price?");
                double pri;
                string pr = Console.ReadLine();
                double.TryParse(pr, out pri);
                items[i] = new Headphone(nm, pri);
            }
        }
        //methods
        public void Print()
        {
            int count = 1;
            Console.WriteLine("--Items in cart below--");
            foreach(Headphone he in items)
            {
                Console.WriteLine($"Item {count}");
                he.Print();
                count++;
            }
        }
        public double CalculateTotal()
        {
            double total = 0;
            foreach(Headphone he in items)
            {
                total += he.Price;
            }
            return total;
        }
        
    }
}
