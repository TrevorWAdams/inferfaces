using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Truck : VehicleBase
    {
        public Truck(IEngine engine) : base(engine)
        {
        }
    }
}
