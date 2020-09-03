using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class UserModel : UserPrototype
    {
        public string FirstName = "";
        public string LastName = "";

        public override UserPrototype Clone()
        {
            return this.MemberwiseClone() as UserPrototype;
        }
    }
}
