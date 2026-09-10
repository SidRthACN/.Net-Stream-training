using System;
using System.Security.Cryptography;

namespace Library_Management_System
{
    public class Library
    {
        private List<Book> books = new();

        public void AddBook()
        {
            Book book = new Book();

            Console.WriteLine("Enter the Book ID: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            book.BookId = ID;

            Console.WriteLine("Enter the Book Title: ");
            string title = Console.ReadLine();
            book.Title = title;

            Console.WriteLine("Enter the Book Author: ");
            string author = Console.ReadLine();
            book.Author = author;

            Console.WriteLine("Enter the number of copies available: ");
            int available = Convert.ToInt32(Console.ReadLine());
            book.Available = available;

            books.Add(book);
            Console.WriteLine("Book added successfully!");
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine("List of all books in the library:");
      
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"Book ID: {books[i].BookId}," +
                                  $" Title: {books[i].Title}," +
                                  $" Author: {books[i].Author}," +       
                                  $" Available Copies: {books[i].Available}");
            }
            Console.WriteLine("Displaying all books completed.");
        }

        public void searchBook()
        {
            Console.WriteLine("Enter the Book ID to search: ");
            int searchId = Convert.ToInt32(Console.ReadLine());
            Book foundBook = books.Find(book => book.BookId == searchId);
            if (foundBook != null)
            {
                Console.WriteLine($"Book found: ID: {foundBook.BookId}, Title: {foundBook.Title}, Author: {foundBook.Author}, Available Copies: {foundBook.Available}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
    }
    
}
