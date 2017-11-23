using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee("Dave","6th street","guy",12345,5000.00);
            em.PrintEmployee();
            em.ChangeName();
            em.ChangeSalary();
            em.PrintEmployee();
        }
    }
}
