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

            //Employee emp1 = new Employee();
            //Employee emp2 = new Employee();
            //Employee emp3 = new Employee();


            //RegularCustomer rc = new RegularCustomer(1, "John Doe", "Credit Card"); 


            //Calculator obj1 = new Calculator();
            //Console.WriteLine("Addition of two numbers is: " + obj1.Add(2, 4));
            //Console.WriteLine("Addition of three numbers is: " + obj1.Add(2, 4, 6));
            //Console.WriteLine("Addition of two doubles is: " + obj1.Add(2.5, 4.52));


            //Animal animal = new Dog();
            //animal.MakeSound();

            //Dog dog = new Dog();
            //dog.MakeSound();

            //Circle c1 = new Circle(5);
            //c1.Display();

            //Square s1 = new Square(54);
            //s1.Display();

            //Exception_Handling ex1 = new Exception_Handling();
            //ex1.display();

            //IChessPiece chessPiece = new ChessPiece("Knight", "White", new string[] { "a1", "b2" });
            //chessPiece.Move();

            //Collections clts = new Collections();
            //clts.display();
            //static void PrintNumbers1_10()
            //{
            //    // Print current thread state
            //    Console.WriteLine("Thread State: " +
            //    Thread.CurrentThread.ThreadState);

            //    for (int i = 0; i <= 1000; i++)
            //    {
            //        Console.Write("{0} ", i);
            //    }
            //}


            //Thread t1 = new Thread(PrintNumbers1_10);
            //Thread t2 = new Thread(PrintNumbers1_10);

            //Console.WriteLine("Before Start : " + t1.ThreadState);
            //Console.WriteLine("Before Start : " + t2.ThreadState); 

            //t1.Start();
            //t2.Start();

            ////t1.Join();
            ////t2.Join();

            //Console.WriteLine("\nAfter Completion : " + t1.ThreadState);
            //Console.WriteLine("\nAfter Completion : " + t2.ThreadState);



            //Multi_Threading mt = new Multi_Threading();
            //Thread t1 = new Thread(mt.M1);
            //Thread t2 = new Thread(mt.M2);
            //Thread t3 = new Thread(mt.M3);

            //t1.Start();
            //t2.Start();
            //t3.Start();


            //t1.Join();
            //t2.Join();  
            //t3.Join();

            NewEmployee emp1 = new NewEmployee(1, "John Doe", "HR");
            NewEmployee emp2 = new NewEmployee(2, "Jane Smith", "Finance");
            NewEmployee emp3 = new NewEmployee(3, "Sam Brown", "IT");
            NewEmployee emp4 = new NewEmployee(4, "Lucy Green", "Marketing");
            NewEmployee emp5 = new NewEmployee(5, "Mike Johnson", "IT");
            NewEmployee emp6 = new NewEmployee(6, "Emily Davis", "Finance");
            NewEmployee emp7 = new NewEmployee(7, "David Wilson", "HR");
            NewEmployee emp8 = new NewEmployee(8, "Sarah Lee", "Marketing");




            LINQ linq = new LINQ();
            linq.AddEmployee(emp1);
            linq.AddEmployee(emp2);
            linq.AddEmployee(emp3);
            linq.AddEmployee(emp4);
            linq.AddEmployee(emp5);
            linq.AddEmployee(emp6);
            linq.AddEmployee(emp7);
            linq.AddEmployee(emp8);


            linq.DisplayEmployeesinIT();

        }
    }
}