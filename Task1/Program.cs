using System;
using Task1;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating  object of Operators class
            Operators op = new Operators();

            // Calling  all methods
            op.Add(20, 10);
            op.Subtract(20, 10);
            op.Multiply(20, 10);
            op.Divide(20, 10);
            op.OddEvenFinder(7);

            Console.ReadLine();
        }
    }
}