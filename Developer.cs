using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Developer :Employee
    {
        public override int GetSalary()
        {
            annulSalary = 8000 + 5 * 2000;
            return annulSalary;
        }
    }
}
