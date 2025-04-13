using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersConsole.Operations
{
    public static class MenuOperations
    {
        public static int ShowMenu()
        {
            Console.WriteLine("Choose action:");
            Console.WriteLine("1. Add new user");
            Console.WriteLine("2. Find user by phrase");
            Console.WriteLine("3. Sort users by last name descending");
            Console.WriteLine("4. Show youngest user");
            Console.WriteLine("5. Show user with longest last name");
            Console.WriteLine("6. Show users with reversed first name");
            Console.WriteLine("7. Exit");
            Console.WriteLine("Select choice: ");

            var value = 0;
            int.TryParse(Console.ReadLine(), out value);

            return value;
        }
    }
}
