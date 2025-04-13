using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using UsersConsole.Models;
using UsersConsole.Repositories;

namespace UsersConsole.Services
{
    public class UsersService
    {
        private readonly UsersRepository usersRepository;

        public UsersService()
        {
            usersRepository = new UsersRepository();
        }

        public void AddUser(User user)
        {
            usersRepository.AddUser(user);
        }

        public void AddUser(string firstName, string lastName, string email, string date)
        {
            
            var newUser = new User()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                BirthDate = DateOnly.Parse(date)
            };

            usersRepository.AddUser(newUser);
        }

        public IEnumerable<User> FindUser(string query)
        {
            return usersRepository.GetUsers(query);
        }

        public IEnumerable<User> ShowUsersLastNameDesc()
        {
            return usersRepository.GetUsers().OrderByDescending(x => x.LastName);
        }

        public User GetYoungestUser()
        {
            return usersRepository.GetUsers().OrderBy(x => x.BirthDate).First();
        }

        public User GetUserWithLongestLastName()
        {
            return usersRepository.GetUsers().OrderByDescending(x => x.LastName.Length).First();
        }

        public IEnumerable<User> GetUsersWithReverseFirstName()
        {
            return usersRepository.GetUsers().Select(x => new User() { FirstName = reverseString(x.FirstName), LastName = x.LastName, Email = x.Email, BirthDate = x.BirthDate });
        }

        private string reverseString(string value)
        {
            char[] charArray = value.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}




//Dodawanie usera                               [X]
//Wyszukiwanie usera po każdym z pól            [X]
//Sortowanie userow po malejąco                 [X]
//Pobieranie najmłdszego usera                  [X]
//Pobieranie usera o najdłuższym nazwisku       [X]
//Zwracanie użytkowaników z odwrócownym imieniem[X]
