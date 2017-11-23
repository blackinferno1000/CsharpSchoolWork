using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE9
{
    class Book
    {
        //private fields for layer of protection
        private string title;
        private string author;
        private int pages;
        private string owner;
        private int read;
        //constructor
        public Book(string ti,string au,int pa,string ow)
        {
            title = ti;
            author = au;
            pages = pa;
            owner = ow;
            read = 0;
        }
        //method to print data
        public void Print()
        {
            Console.WriteLine("Title: "+ title);
            Console.WriteLine("Author: "+author);
            Console.WriteLine("Pages: "+pages);
            Console.WriteLine("Owner: "+owner);
            Console.WriteLine("Number of times read: "+read);
        }
        //getters and setters
        public string Title
        {
            get { return title; }
        }
        public string Author
        {
            get { return author; }
        }
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public int Pages
        {
            get { return pages; }
        }
        public int Read
        {
            get { return read; }
            set
            {
                if (value > read)
                { read = value; }
                else { read = 0; }
            }
        }
    }
}
