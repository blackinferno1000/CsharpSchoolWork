using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE18
{
    /*
     * Sean Lightfoot
     * PE18
     * Stack practice
     */
    class Program
    {
        static void Main(string[] args)
        {
            //stacks instantiated
            Stack<string> backward = new Stack<string>();
            Stack<string> forward = new Stack<string>();
            string current = "";
            //instructions 
            Console.WriteLine($"1 visits a new webpage");
            Console.WriteLine($"2 moves forward to the next page");
            Console.WriteLine($"3 moves back to previous page");
            Console.WriteLine($"4 prints current page, and back and forward stacks");
            Console.WriteLine($"5 quits the loop");
            int in1 = 0;
            string input;
            //loop for interaction
            while(in1 != 5)
            {
                input = Console.ReadLine();
                int.TryParse(input, out in1);
                switch (in1)
                {
                    case 1: current = VisitPage(forward, backward);
                        Console.WriteLine($"current page: {current}");
                        break;
                    case 2: current = MoveForward(forward, backward);
                        Console.WriteLine($"current page: {current}");
                        break;
                    case 3: current = MoveBack(forward, backward);
                        Console.WriteLine($"current page: {current}");
                        break;
                    case 4: PrintStack(forward,backward,current);
                        break;
                }
            }
        }
        //static methods
        public static string VisitPage(Stack<string> forward,Stack<string> backward)
        {
            Console.WriteLine($"enter a page");
            string input = Console.ReadLine();
            backward.Push(input);
            forward.Clear();
            return input;
        }
        public static string MoveForward(Stack<string> forward, Stack<string> backward)
        {
            if(forward.Count == 0)
            {
                Console.WriteLine($"Empty");
            }
            string current = forward.Pop();
            backward.Push(current);
            Console.WriteLine($"{current} was added to backward history and removed from forward history");
            return current;
        }
        public static string MoveBack(Stack<string> forward, Stack<string> backward)
        {
            if (backward.Count == 0)
            {
                Console.WriteLine($"Empty");
            }
            string current = backward.Pop();
            forward.Push(current);
            Console.WriteLine($"{current} was removed from backward history and added to forward history");
            return backward.Peek();
        }
        public static void PrintStack(Stack<string> forward, Stack<string> backward, string cur)
        {
            Console.WriteLine($"-----Current Page-----");
            Console.WriteLine(cur);
            Console.WriteLine($"-----forward stack-----");
            if (forward.Count == 0)
            {
                Console.WriteLine($"<Empty>");
            }
            foreach (string s in forward)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine($"-----backward stack-----");
            if (backward.Count == 0)
            {
                Console.WriteLine($"<Empty>");
            }
            foreach (string s in backward)
            {
                Console.WriteLine(s);
            }
        }
    }
}
