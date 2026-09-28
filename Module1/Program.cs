using System;

namespace Module1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter Your Name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello,"+name+"!");


            //// method calling 
            //Console.WriteLine("Method Declaration Example");
            //Method_Declaration method = new Method_Declaration();
            //method.display();


            //// Datatypes
            //Console.WriteLine("\nDatatypes Example");
            //datatypes data = new datatypes();
            //data.display();

            //datatypes.Coordinate d1 = new datatypes.Coordinate();
            //datatypes.Coordinate d2 = d1;
            //d1.assign(10, 20);
            //d1.display();
            //d2.display();

            //datatypes.Coordinate p1 = new datatypes.Coordinate();
            //p1.assign(10, 20);

            //datatypes.Coordinate p2 = p1;

            //p2.x = 100;

            //p1.display();
            //p2.display();

            //Access_Modifiers access = new Access_Modifiers();
            ////access.display();
            //access.Name = "John Doe";
            //access.Age = 30;
            //access.display();

            Console.WriteLine("Hello World!");


            Trainer obj0 = new Trainer();
            Trainer obj1 = new Trainer(101, "Peter", "Dotnet");
            Trainer obj2 = new Trainer(102, "Angie", "Java");

            obj0.display();
            obj1.display();
            obj2.display();







        }
    }
}