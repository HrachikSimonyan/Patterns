using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public abstract class Msaker
    {
        public abstract void Eat(Busaker h);
    }

    public class Lion : Msaker
    {
        public override void Eat(Busaker h)
        {
            Console.WriteLine("Lion eats " + h.GetType().Name);
        }
    }

    public class Wolf : Msaker
    {
        public override void Eat(Busaker h)
        {
            Console.WriteLine("Wolf eats " + h.GetType().Name);
        }
    }
}
