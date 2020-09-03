using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public sealed class Safe
    {
        private static Safe instance = null;
        private static readonly object padlock = new object();

        Safe()
        {
        }

        public static Safe Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Safe();
                    }
                    return instance;
                }
            }
        }
    }
}
