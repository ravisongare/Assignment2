using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class HR : Employee

    {
    public override int GetSalary()
       {
            annulSalary = 8000 + 4 * 1000;
            return annulSalary;
       }
    }
}
