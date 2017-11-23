using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE10
{
    /*
     * Sean Lightfoot
     * PE10
     * Multiple classes and object practice
     */
    class Program
    {
        static void Main(string[] args)
        {
            //default constructor cart created and info displayed
            Cart ca = new Cart();
            ca.Print();
            double total = ca.CalculateTotal();
            Console.WriteLine($"Total: {total}");
            //parameterized constructor cart created and info displayed
            Cart car = new Cart(3);
            car.Print();
            total = car.CalculateTotal();
            Console.WriteLine($"Total: {total}");
        }
    }
}
