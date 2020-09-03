using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public abstract class ContinentFactory
    {
        public abstract Busaker CreateBusaker();
        public abstract Msaker CreateMsaker();
    }
}
