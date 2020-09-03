using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public sealed class NotSafe
    {
        private static NotSafe instance = null;

        private NotSafe()
        {
        }

        public static NotSafe Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NotSafe();
                }
                return instance;
            }
        }
    }
}
