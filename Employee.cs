using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
  public abstract class Employee
    {
       protected int _Id;
       protected string Name;
       protected string Designation;
       protected float Experiance;
       protected  int annulSalary;
       protected string joiningDate;

        public abstract int GetSalary();
    }  
}
