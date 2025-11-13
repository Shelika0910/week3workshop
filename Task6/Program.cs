using System;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You entered: " + num);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }

            // throw exception
            Console.Write("\nEnter password: ");
            string password = Console.ReadLine();

            if (password.Length < 6)
            {
                throw new Exception("Password must be at least 6 characters.");
            }
            else
            {
                Console.WriteLine("Password satisfied the requirement");
            }


        }
    }
}