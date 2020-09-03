using System;

namespace PrototypePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static void Execute()
        {
            UserModel user = new UserModel();
            user.FirstName = "Poxos";
            user.LastName = "Poxosyan";
            Console.WriteLine($"User created {user.FirstName} {user.LastName}");

            Console.WriteLine();
            UserModel user2 = user;
            Console.WriteLine("Pass user to user2");
            user2.FirstName = "Petros";
            Console.WriteLine("User2 firstname changed");
            Console.WriteLine($"User {user.FirstName} {user.LastName}");

            Console.WriteLine();
            UserModel user3 = user.Clone() as UserModel;
            Console.WriteLine("Memberwise clone user to user3");
            user3.FirstName = "Martiros";
            Console.WriteLine("User3 firstname changed");
            Console.WriteLine($"User {user.FirstName} {user.LastName}");
        }
    }
}
