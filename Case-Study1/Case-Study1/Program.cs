using System;


namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============Library Management System============");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Search Book");
            Console.WriteLine("3. Issue Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Display All Books");
            Console.WriteLine("6. Exit");

            Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());


            Library library = new Library();
            while (choice != 6)
            {
                if(choice == 1)
                {
                    library.AddBook();
                }
                else if(choice == 2)
                {
                    library.searchBook();
                }
                else if (choice == 5)
                {
                    library.DisplayAllBooks();
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

                Console.WriteLine("\nEnter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            
        }
    }
}
