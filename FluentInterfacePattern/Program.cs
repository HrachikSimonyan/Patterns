using System;

namespace FluentInterfacePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static void Execute()
        {

            FluentUser fluentUser = new FluentUser();

            var user = fluentUser.UserFirstName("Poxos")
                                 .UserLastName("Poxosyan")
                                 .Address("Azatutyan 24/15")
                                 .BirthDate(DateTime.Now)
                                 .PhoneNumber("+3747777777")
                                 .GetUser();

            Console.WriteLine(user.FirstName + " " + user.LastName);
            Console.WriteLine(user.DateOfBirth);
            Console.WriteLine(user.Address);
            Console.WriteLine(user.PhoneNumber);
        }
    }
}
