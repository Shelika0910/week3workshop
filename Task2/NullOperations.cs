using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class NullOperations
    {


        public void PerformNullChecks()
        {
            string username = null;

            // Ternary operator
            string message = (username == null) ? "Username is not available" : username;
            Console.WriteLine(message);

            // Null-coalescing operator
            Console.WriteLine(username ?? "Username is not available");

            // Null-coalescing assignment
            username ??= "DefaultUser";
            Console.WriteLine("Updated username: " + username);
        }
    }
}