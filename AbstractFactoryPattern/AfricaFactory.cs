using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class AfricaFactory : ContinentFactory
    {
        public override Busaker CreateBusaker()
        {
            return new Wildebeest();
        }
        public override Msaker CreateMsaker()
        {
            return new Lion();
        }
    }
}
