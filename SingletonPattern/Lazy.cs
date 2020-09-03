using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public sealed class Lazy
    {
        private Lazy()
        {
        }

        public static Lazy Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly Lazy instance = new Lazy();
        }
    }
}
