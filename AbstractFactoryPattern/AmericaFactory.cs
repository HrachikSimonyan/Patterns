using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class AmericaFactory : ContinentFactory
    {
        public override Busaker CreateBusaker()
        {
            return new Bison();
        }
        public override Msaker CreateMsaker()
        {
            return new Wolf();
        }
    }
}
