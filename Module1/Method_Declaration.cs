using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
     public class Method_Declaration
    {

        /*
            method declaration syntax:
            1)  return type 
            2)  method name
            3)  parameter list (method signature)
            4)  method body
         
         */

        // adding two numers using method decalration

        int add(int a, int b) // method signature
        {
            return a + b; // method body
        }

        public void display()
        {
            Console.WriteLine("Enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = add(num1, num2); // method call
            Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, result);
        }   



    }
}
