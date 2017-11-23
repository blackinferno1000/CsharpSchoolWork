using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    /*
     * Sean Lightfoot
     * Section 1
     * Project 1
     * ASCII Replacer
    */
    class Program
    {
        static void Main(string[] args)
        {
            //array of ascii
            string[] ascii = new string[3];

            //displaying and storing the ascii in the array
            Console.WriteLine("a.");
            Console.WriteLine("      |~~~~~~~~~~~~~~~|\n      |~~~~~~~~~~~~~~~|\n      |               |\n" +
                "  /~~\\|           /~~\\|\n  \\__/            \\__/ ");

            ascii[0] = "      |~~~~~~~~~~~~~~~|\n      |~~~~~~~~~~~~~~~|\n      |               |\n" +
                "  /~~\\|           /~~\\|\n  \\__/            \\__/ ";

            Console.WriteLine("b.");
            Console.WriteLine(" ,\n ;;\n ;;\n ;;\n " +
                ";;\n ;; .;; ;,\n ;;.'  ;;\n ;;' .;'\n ;;.;'\n ;;'\n,'");

            ascii[1] = " ,\n ;;\n ;;\n ;;\n " +
                ";;\n ;; .;; ;,\n ;;.'  ;;\n ;;' .;'\n ;;.;'\n ;;'\n,'";

            Console.WriteLine("c.");
            Console.WriteLine("      |\\          .\n      |/          |\\\n------|-----------|/-----\n     /|" +
                "           |\n----/-|----------/|------\n   / _|_        / |\n--/-/-|-\\------/-_|_-----\n ( (  |" +
                "  \\    / / | \\\n--\\-\\_|)-/----\\-\\_|) )---\n   \\__|_/      \\__|_/\n------|" +
                "-----------|------\n      |          \\|\n    `-'");

            ascii[2] = "      |\\          .\n      |/          |\\\n------|-----------|/-----\n     /|" +
                "           |\n----/-|----------/|------\n   / _|_        / |\n--/-/-|-\\------/-_|_-----\n ( (  |" +
                "  \\    / / | \\\n--\\-\\_|)-/----\\-\\_|) )---\n   \\__|_/      \\__|_/\n------|" +
                "-----------|------\n      |          \\|\n    `-'";
            //beginning of game
            Console.WriteLine("Which text would you like to play with?");
            char input = GetUserChar('a','c');
            int choice = 3;

            //switch statement to easily use input to get a proper indexer
            switch (input)
            {
                case 'a': choice = 0;
                    break;
                case 'b': choice = 1;
                    break;
                case 'c': choice = 2;
                    break;
            }
            //continuation of game
            //prompts and storing validated input in proper fields
            Console.WriteLine("Which character would you like to replace? ");
            char ans1 = GetUserChar((char)' ','~');
            Console.WriteLine("Which character would you like to replace it with?\n " +
                "(type ' ' -SPACE- if you'd like a random one)");
            char ans2 = GetUserChar((char)' ', '~');

            //shows what is being replaced and by what
            Console.WriteLine("Original character: " + ans1 + " replaced with: " + ans2);

            //method that replaces the chars in the string, takes in string from ascii
            //array at proper indexer found above
            string answer = ReplaceChar(ascii[choice], ans1, ans2);

            //display the changed ascii and thank you message
            Console.WriteLine(answer);
            Console.WriteLine("ASCII from: https://www.ascii-code.com/ascii-art/music/musical-notation.php");
            Console.WriteLine("-----Thank you for playing-----");
        }
        //method to get input and validate it
        static char GetUserChar(char a,char c)
        {
            //fields
            int i = -1;
            char choice = 'd';
            string input = Console.ReadLine();
            input = input.ToLower();
            if (input.Length > 1)
            {
                Console.WriteLine($"enter a character between {a} and {c}");
                input = Console.ReadLine();
            }
            char.TryParse(input, out choice);
            //loop to validate
            do
            {
                if (choice < a || choice > c)
                {
                    Console.WriteLine($"enter a character between {a} and {c}");
                    choice = Convert.ToChar(Console.ReadLine());
                }

                if (choice == ' ')
                {
                    Random rgen = new Random();
                    choice = (char)rgen.Next(' ', 1 + '~');
                    i++;
                }

                else 
                {
                    i++;
                }
            }
            while (i > 0);

            return choice;
        }
        //method to replace chars in string
        static string ReplaceChar(string ch,char se,char re)
        {
            //array to hold chars from string and replaced chars
            char[] charray = new char[ch.Length];
            //loop to store and replace chars
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == se)
                {
                    charray[i] = re;
                }
                else
                {
                    charray[i] = ch[i];
                }
            }
            //building of new string object to convert char array into a string
            string answer = new string(charray);
            return answer;

        }
    }
}
