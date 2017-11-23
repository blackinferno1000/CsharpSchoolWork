using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6
{
    /*
     *Sean Lightfoot
     * PE6
     * Methods practice
     */
    class Program
    {
        static void Main(string[] args)
        {
            Random rgen = new Random();
            string myName = "Sean Lightfoot";
            Introduction(myName);
            PrintReversed(myName);
            Console.WriteLine("  <-Text reversed");
            string userText = GetUserString();
            Console.Write(userText);
            Console.WriteLine("  <-Text input");
            string textReversed = ReturnReversed(userText);
            Console.Write(textReversed);
            Console.WriteLine("  <-Text reversed");
            string textEncoded = EncodeText(userText, rgen);
            Console.Write(textEncoded);
            Console.WriteLine("  <-Text encoded");
        }

        //prints sentence with inputted name
        static void Introduction(string nm)
        {
            Console.WriteLine("Welcome to Text Twister, created by " + nm);
        }

        //prints reversed
        static void PrintReversed(string nm)
        {
            for(int i = nm.Length - 1; i>=0 ; i--)
            {
                Console.Write(nm[i]);
            }
        }

        //gets user string
        static string GetUserString()
        {
            string text = Console.ReadLine();
            return text;
        }

        //returns reversed string
        static string ReturnReversed(string nm)
        {
            string text = "";
            for (int i = nm.Length-1; i >= 0; i--)
            {
                text += nm[i];
            }
            return text;
        }

        //encodes text
        static string EncodeText(string nm, Random rgen)
        {
            char[] charArray = new char[nm.Length];
            for(int i = 0; i < nm.Length; i++)
            {
                if (i % 2 == 0)
                {
                    charArray[i] = (char)rgen.Next(65, 90);
                }
                else
                {
                    charArray[i] = nm[i];
                }
            }
            string text = new string(charArray);
            return text;
        }
    }
}
