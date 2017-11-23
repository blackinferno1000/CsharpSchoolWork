using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PE20
{
    /*
     *Sean Lightfoot
     * PE20
     * Text File I/O practice
     */
    class Program
    {
        static void Main(string[] args)
        {
            //filenames stored in variables
            string colors = "colors.txt";
            string text = "myWrittenData.txt";
            //methods called
            ReadData(colors);
            WriteData(text);
        }
        //read method
        static void ReadData(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            Console.WriteLine($"Opened file");
            try
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string input = sr.ReadLine();
                    string[] data = input.Split('|');
                    for(int i = 0; i < data.Length; i++)
                    {
                        Console.WriteLine($"color {i + 1}: {data[i]}");
                    }
                }
                Console.WriteLine($"Read file");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
                Console.WriteLine($"Closed file");
            }
        }
        //write method
        static void WriteData(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create);
            Console.WriteLine($"Created file");
            try
            {
                using(StreamWriter output = new StreamWriter(fs))
                {
                    output.WriteLine("Open file");
                    output.WriteLine("Read file");
                    output.WriteLine("Close file");
                }
                Console.WriteLine($"Wrote to file");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
                Console.WriteLine($"Closed file");
            }
        }
    }
}
