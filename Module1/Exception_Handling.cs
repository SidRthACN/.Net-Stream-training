using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    internal class Exception_Handling
    {
        public void display()
        {
            //try
            //{
            //    Console.WriteLine("Enter a number");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter another number");
            //    int num2 = Convert.ToInt32(Console.ReadLine());
            //    int result = num1 / num2;
            //    Console.WriteLine("Result is: " + result);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Error: Invalid input format. Please enter a valid integer." + ex.Message);
            //}   
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An unexpected error occurred: " + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Execution completed.");
            //}

            try
            {
                Console.WriteLine("Enter a number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter another number");
                int num2 = int.Parse(Console.ReadLine());
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution Complete");
            }
        }
    }
}
