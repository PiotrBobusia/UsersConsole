using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using UsersConsole.Models;

namespace UsersConsole.Operations
{
    public static class DisplayOperations
    {
        public static void Display(User user)
        {
            var table = new ConsoleTable("FirstName", "LastName", "Email", "BirthDate");

            table.AddRow(user.FirstName, user.LastName, user.Email, user.BirthDate.ToString());

            table.Write();
        }
        

        public static void Display(IEnumerable<User> users)
        {
            var table = new ConsoleTable("FirstName", "LastName", "Email", "BirthDate");

            foreach(User item in users)
            {
                table.AddRow(item.FirstName, item.LastName, item.Email, item.BirthDate.ToString());
            }

            table.Write();
        }
    }
}
