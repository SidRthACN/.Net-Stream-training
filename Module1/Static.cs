using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    public class Employee
    {
        int EmpId;
        string EmpName;
        // static variable to keep track of the number of employees created
        // without static variable, each instance of Employee class will have its own copy of the variable and it will not be shared among all instances.
        // so the op would be 1,1,1 instead of 1,2,3.
        static int cnt = 0;


        private int GenerateId()
        {
            EmpId = ++cnt;
            return EmpId;
        }
        public Employee()
        {
            EmpId = GenerateId();
            Console.WriteLine("Employee ID: " + EmpId);
        
        }
    }
}
