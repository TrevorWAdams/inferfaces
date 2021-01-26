using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Car : VehicleBase
    {
        public int Year { get; set; }

        public Car(IEngine engine) : base(engine)
        {
        }
    }
}
