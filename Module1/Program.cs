using System;

namespace Module1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello,"+name+"!");


            Console.WriteLine("Data Types in C#");

            datatypes dt = new datatypes();
            dt.display();

        }
    }
}