using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    public abstract class CarFactory
    {
        public abstract Car CreateCar(string model);
    }
}
