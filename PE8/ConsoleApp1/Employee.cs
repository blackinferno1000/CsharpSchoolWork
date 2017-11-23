using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8
{
    class Employee
    {
        public string name;
        public string address;
        public string title;
        public int number;
        public double salary;

        public Employee()
        {
            name = "Employee";
            address = "123 Main Street";
            title = "Worker";
            number = 00000;
            salary = 0.00;
        }

        public Employee(string nm,string add,string ti,int num,double sal)
        {
            name = nm;
            address = add;
            title = ti;
            number = num;
            salary = sal;
        }

        public void ChangeName()
        {
            Console.WriteLine("new name?");
            string na = Console.ReadLine();
            this.name = na;
        }

        public void ChangeSalary()
        {
            Console.WriteLine("new salary?");
            double sl;
            string sa = Console.ReadLine();
            double.TryParse(sa, out sl);
            this.salary = sl;
        }

        public void PrintEmployee()
        {
            Console.WriteLine(name+"'s stat's");
            Console.WriteLine("Name: " +name);
            Console.WriteLine("Address: " +address);
            Console.WriteLine("Title: " +title);
            Console.WriteLine("Number: " +number);
            Console.WriteLine("Salary: " +salary);
        }

    }
}
