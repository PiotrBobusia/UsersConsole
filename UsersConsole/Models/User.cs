using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersConsole.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string _email;
        public string Email
        {
            get => _email;
            set
            {
                var isValid = new EmailAddressAttribute().IsValid(value);

                if (isValid) _email = value;
                else throw new ArgumentException("Wrong email! Please check syntax");
            }
        }

        private DateOnly _birthDate;
        public DateOnly BirthDate 
        {
            get => _birthDate; 
            set
            {
                var dateNow = DateOnly.FromDateTime(DateTime.Now);

                if (value < dateNow) _birthDate = value;
                else throw new ArgumentException("Wrong birth date! Please check the date");
            }
        }
    }
}
