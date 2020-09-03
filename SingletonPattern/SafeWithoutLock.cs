using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public sealed class SafeWithoutLock
    {
        private static readonly SafeWithoutLock instance = new SafeWithoutLock();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static SafeWithoutLock()
        {
        }

        private SafeWithoutLock()
        {
        }

        public static SafeWithoutLock Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
