using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    public abstract class Employee
    {
        public abstract Employee Clone();

        public string Name { get; set; }
        public string Role { get; set; }

    }
}
