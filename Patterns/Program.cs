using SingletonPattern;
using System;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Singleton");
                Console.WriteLine(new string('-', 20));
                SingletonPattern.Program.Execute();
                Console.WriteLine(new string('-', 20));
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Factory");
                Console.WriteLine(new string('-', 20));
                FactoryPattern.Program.Execute();
                Console.WriteLine(new string('-', 20));
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Abstract Factory");
                Console.WriteLine(new string('-', 20));
                AbstractFactoryPattern.Program.Execute();
                Console.WriteLine(new string('-', 20));
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Builder");
                Console.WriteLine(new string('-', 20));
                BuilderPattern.Program.Execute();
                Console.WriteLine(new string('-', 20));
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Fluent interface");
                Console.WriteLine(new string('-', 20));
                FluentInterfacePattern.Program.Execute();
                Console.WriteLine(new string('-', 20));
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Prototype");
                Console.WriteLine(new string('-', 20));
                PrototypePattern.Program.Execute();
                Console.WriteLine(new string('-', 20));
                Console.WriteLine();

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.Read();
        }
    }
}
