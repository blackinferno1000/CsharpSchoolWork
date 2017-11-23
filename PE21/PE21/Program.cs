using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE21
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2D array holds info about each character
            // Array is initialized to all dots for now
            // This will later change and hold either dots, b's, or other letters
            char[,] webpage = new char[100, 100];
            webpage = InitializeArray(webpage);

            // 1. Create Button and Link lists 
            List<Button> but = new List<Button>();
            List<Hyperlink> hyp = new List<Hyperlink>();
            but.Add(new Button("Click Me!", 10, 10, 20, 5));
            but.Add(new Button("Edit", 45, 10, 15, 5));
            but.Add(new Button("Submit", 75, 10, 15, 8));

            // 2. Create Buttons and add to list.
            but.Add(new Button("Click Me!", 10, 10, 20, 5));
            but.Add(new Button("Edit", 45, 10, 15, 5));
            but.Add(new Button("Submit", 75, 10, 15, 8));
            // 3. Create Links and add to list.
            hyp.Add(new Hyperlink("Google", "www.google.com", 15, 5));
            hyp.Add(new Hyperlink("MyCourses", "www.mycourses.com", 45, 5));

            // 4. Change the positions of some Buttons and Links
            but[1].ChangePosition(0, 0);
            but[2].ChangeXPosition(5);
            but[2].ChangeYPosition(80);
            hyp[0].ChangeYPosition(15);

            // 5. Set the data and draw all UI elements
            SetPageData(but, hyp,webpage);
            DrawPage(webpage);

        }



        /// <summary>
        /// InitializeArray()
        /// Fills any empty 2D character array with dots
        /// </summary>
        /// <param name="pageArray">Empty 2D character array of any size.</param>
        /// <returns>Returns that 2D character array with every character initialized to a dot.</returns>
        public static char[,] InitializeArray(char[,] pageArray)
        {
            for (int r = 0; r < pageArray.GetLength(0); r++)
            {
                for (int c = 0; c < pageArray.GetLength(1); c++)
                {
                    pageArray[r, c] = '.';
                }
            }
            return pageArray;
        }


        /// <summary>
        /// SetPageData()
        /// Iterates through a 2D character array and "draws" each element to the console window. 
        /// </summary>
        /// <param name="buttonList">List of Buttons</param>
        /// <param name="linkList">List of Hyperlinks</param>
        /// <param name="webpage">2D character array</param>
        /// Returns: none
        public static void SetPageData(List<Button> buttonList, List<Hyperlink> linkList, char[,] webpage)
        {
            // Set the data for all hyperlinks
            foreach (Hyperlink h in linkList)
            {
                int row = h.X;
                int col = h.Y;

                for (int i = 0; i < h.LinkAddress.Length; i++)
                {
                    webpage[col, row] = h.LinkAddress[i];
                    row++;
                }
            }

            // Set the data for all buttons
            foreach (Button b in buttonList)
            {
                // Grab the starting index
                int row = b.Y;
                int col = b.X;

                for (int c = 0; c < b.ButtonHeight; c++)
                {
                    for (int r = 0; r < b.ButtonWidth; r++)
                    {
                        webpage[row, col] = 'B';

                        // Draw the top and bottom button lines
                        if (c == 0 || c == b.ButtonHeight - 1)
                        {
                            webpage[row, col] = 'B';
                        }
                        // Draw the left and right lines
                        else if (col == b.X || col == (b.X - 1 + b.ButtonWidth))
                        {
                            webpage[row, col] = 'B';
                        }
                        // Everything else is blank
                        else
                        {
                            webpage[row, col] = ' ';
                        }

                        // Increase column counter to keep track of horizontal alignment
                        col++;
                    }

                    // Move to next row
                    row++;
                    // Reset column number
                    col = b.X;
                }

                // Add the button text
                for (int i = 0; i < b.ButtonText.Length; i++)
                {
                    webpage[b.Y + 1, b.X + i + 3] = b.ButtonText[i];
                }
            }
        }


        /// <summary>
        /// DrawPage()
        /// Draws each UI element on the page
        /// </summary>
        /// <param name="webpage">2D character array</param>
        /// Returns: none
        public static void DrawPage(char[,] webpage)
        {
            // Starting boundary line
            for (int i = 0; i < 104; i++)
            {
                Console.Write("-");
            }
            Console.Write("\n");

            // Draw everything in array
            for (int row = 0; row < 100; row++)
            {
                if (row < 10)
                {
                    Console.Write(" " + row + "|");
                }
                else
                {
                    Console.Write(row + "|");
                }

                for (int col = 0; col < 100; col++)
                {
                    Console.Write(webpage[row, col]);
                }
                Console.Write("|");
                Console.Write("\n");
            }

            // Ending boundary line
            for (int i = 0; i < 104; i++)
            {
                Console.Write("-");
            }
            Console.Write("\n");
        }
    }
}
