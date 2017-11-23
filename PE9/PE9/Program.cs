using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE9
{
    /*
     * Sean Lightfoot
     * PE9
     * property practice
    */
    class Program
    {
        static void Main(string[] args)
        {
            //object creation and input holder
            Book boo = new Book("Go", "Masashi Kishimoto", 300, "Joe");
            string choice = "";
            //loop to take input
            while (choice != "done")
            {
                Console.WriteLine("");
                Console.WriteLine("Enter one of following to access book: ");
                Console.WriteLine("title, author, pages, borrow, read, print, done");
                choice = Console.ReadLine();
                Console.WriteLine("");
                if (choice == "title")
                {
                    Console.WriteLine("Title: "+boo.Title);
                }
                if (choice == "author")
                {
                    Console.WriteLine("Author: "+boo.Author);
                }
                if (choice == "pages")
                {
                    Console.WriteLine("number of pages: "+boo.Pages);
                }
                if (choice == "borrow")
                {
                    Console.WriteLine("who's borrowing it?");
                    boo.Owner = Console.ReadLine();
                    Console.WriteLine("new owner: " + boo.Owner);
                }
                if (choice == "read")
                {
                    boo.Read++;
                    Console.WriteLine("book read again new number of times read: " + boo.Read);
                }
                if (choice == "print")
                {
                    boo.Print();
                }
                //makes sure that words are input correctly
                if (choice != "title" && choice != "author" && choice != "pages" 
                    && choice != "borrow" && choice != "read" && choice != "print")
                {
                    Console.WriteLine("invalid data! retry!");
                }
            }
            //goodbye message
            Console.WriteLine("Goodbye");
        }
    }
}
