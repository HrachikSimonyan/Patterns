using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class AnimalWorld
    {
        private Busaker _herbivore;
        private Msaker _carnivore;

        public AnimalWorld(ContinentFactory factory)
        {
            _carnivore = factory.CreateMsaker();
            _herbivore = factory.CreateBusaker();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
