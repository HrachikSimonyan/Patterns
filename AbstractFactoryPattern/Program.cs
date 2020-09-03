using System;

namespace AbstractFactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static void Execute()
        {
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();
            
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();
        }
    }
}
