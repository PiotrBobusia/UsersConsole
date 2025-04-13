using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersConsole.Models;

namespace UsersConsole.Repositories
{
    public class UsersRepository
    {
        private HashSet<User> UsersDB { get; set; }

        public UsersRepository()
        {
            UsersDB = new();
            Seed();
        }
        public void Seed()
        {
            UsersDB.Add(new User() { FirstName = "Adam", LastName = "Nowak", Email = "a.nowak@gmail.com", BirthDate = new DateOnly(1995,01,13)});
            UsersDB.Add(new User() { FirstName = "Karolina", LastName = "Adamik", Email = "kadamik88@gmail.com", BirthDate = new DateOnly(1988, 05, 22) });
            UsersDB.Add(new User() { FirstName = "Piotr", LastName = "Jurusik", Email = "jurus13@o2.pl", BirthDate = new DateOnly(1997, 04, 17) });
            UsersDB.Add(new User() { FirstName = "Anna", LastName = "Lipka", Email = "a.lipka@wp.pl", BirthDate = new DateOnly(2001, 11, 26) });
            UsersDB.Add(new User() { FirstName = "Janek", LastName = "Tomczyk", Email = "janek.tomczyk@gmail.com", BirthDate = new DateOnly(1990, 08, 27) });
        }

        public void AddUser(User user)
        {
            UsersDB.Add(user);
        }

        public IEnumerable<User> GetUsers(string queryString)
        {
            return UsersDB.Where(x => x.FirstName.Equals(queryString, StringComparison.OrdinalIgnoreCase)
                            || x.LastName.Equals(queryString, StringComparison.OrdinalIgnoreCase)
                            || x.Email.Equals(queryString, StringComparison.OrdinalIgnoreCase)
                            || x.BirthDate.ToString().Equals(queryString, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<User> GetUsers()
        {
            return UsersDB;
        }
    }

}
