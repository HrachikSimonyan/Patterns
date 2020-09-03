using System;
using System.Collections.Generic;
using System.Text;

namespace FluentInterfacePattern
{
    public class FluentUser
    {
        private User User = new User();

        public FluentUser UserFirstName(string firstName)
        {
            User.FirstName = firstName;
            return this;
        }

        public FluentUser UserLastName(string lastName)
        {
            User.LastName = lastName;
            return this;
        }

        public FluentUser BirthDate(DateTime dateOfBirth)
        {
            User.DateOfBirth = dateOfBirth;
            return this;
        }

        public FluentUser Address(string address)
        {
            User.Address = address;
            return this;
        }

        public FluentUser PhoneNumber(string phoneNumber)
        {
            User.PhoneNumber = phoneNumber;
            return this;
        }

        public User GetUser()
        {
            return User;
        }
    }
}
