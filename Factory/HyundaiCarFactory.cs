using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    public class HyundaiCarFactory : CarFactory
    {
        public override Car CreateCar(string model)
        {
            switch (model.ToLower())
            {
                case "coupe": return new HyundaiCoupe();
                case "i30": return new HyundaiI30();
                default: throw new ArgumentException("Invalid model.", "model");
            }
        }

    }
}
