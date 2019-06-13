using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee hr = new HR();
            Employee developer = new Developer();
            Console.WriteLine($"Salry of HR :{hr.GetSalary()}");
            Console.WriteLine($"Salary of Developer:{developer.GetSalary()}");
            Console.ReadLine();
        }
    }
}
