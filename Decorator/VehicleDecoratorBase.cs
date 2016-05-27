using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public abstract class VehicleDecoratorBase : VehicleBase
    {
        private VehicleBase _vehicle;

        public VehicleDecoratorBase(VehicleBase vehicle)
        {
            _vehicle = vehicle;
        }

        public override string Make
        {
            get { return _vehicle.Make; }
        }

        public override string Model
        {
            get { return _vehicle.Model; }
        }

        public override double HirePrice
        {
            get { return _vehicle.HirePrice; }
        }

        public override int HireLaps
        {
            get { return _vehicle.HireLaps; }
        }

    }
}
