using System;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static void Execute()
        {
            var arr = new int[] { 1, 2 };

            Console.WriteLine("Not safe!");
            Parallel.ForEach(arr, (currentIndex) =>
            {
                NotSafe instance = NotSafe.Instance;
                Console.WriteLine($"{currentIndex} instance hashcode: {instance.GetHashCode()}");
            });

            Console.WriteLine(new string('*', 20));
            Console.WriteLine("Safe with lock");
            Parallel.ForEach(arr, (currentIndex) =>
            {
                Safe instance = Safe.Instance;
                Console.WriteLine($"{currentIndex} instance hashcode: {instance.GetHashCode()}");
            });

            Console.WriteLine(new string('*', 20));
            Console.WriteLine("Safe without lock");
            Parallel.ForEach(arr, (currentIndex) =>
            {
                SafeWithoutLock instance = SafeWithoutLock.Instance;
                Console.WriteLine($"{currentIndex} instance hashcode: {instance.GetHashCode()}");
            });

            Console.WriteLine(new string('*', 20));
            Console.WriteLine("Lazy");
            Parallel.ForEach(arr, (currentIndex) =>
            {
                Lazy instance = Lazy.Instance;
                Console.WriteLine($"{currentIndex} instance hashcode: {instance.GetHashCode()}");
            });

        }
    }
}
