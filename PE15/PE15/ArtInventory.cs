using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE15
{
    class ArtInventory
    {
        //field
        private List<string> srlist;
        //constructor
        public ArtInventory()
        {
            srlist = new List<string>();
        }
        //methods
        public void AddToInventory()
        {
            Console.WriteLine("What art item do you want added to list?");
            string input = Console.ReadLine();
            if (input == "done")
            {
                
            }
            else
            {
                srlist.Add(input);
                Console.WriteLine($"{input} added to the inventory");
            }
        }
        public void AddToInventory(string item)
        {
            srlist.Add(item);
            Console.WriteLine($"{item} added to the inventory");
        }
        public void PrintInventory()
        {
            foreach(string str in srlist)
            {
                Console.WriteLine($"Item {srlist.IndexOf(str)}: {str}");
                Console.WriteLine($"");
            }
        }
        public void RemoveFromInventory()
        {
            Console.WriteLine($"what is the index of the item you want to remove");
            string input = Console.ReadLine();
            int num;
            if (input == "done")
            {

            }
            else
            {
                int.TryParse(input, out num);

                if(num >= 0 && num < srlist.Count)
                {
                    Console.WriteLine($"removed index {num}, {srlist[num]}, from the list");
                    srlist.RemoveAt(num);
                }
                else
                {
                    Console.WriteLine($"index must be between 0 and {srlist.Count}!");
                }
            }
        }
        public void ListCount()
        {
            Console.WriteLine($"There are {srlist.Count} items in your inventory");
        }
    }
}
