using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public abstract class VehicleBase : IVehicle
    {
        public int Speed { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public bool IsStarted => Engine.IsStarted;

        public IEngine Engine { get; }

        public VehicleBase(IEngine engine)
        {
            Engine = engine;
        }


        public virtual void StartEngine()
        {
            if (IsStarted)
            {
                throw new Exception("Already started");
            }

            Engine.Start();
        }

        public void StopEngine()
        {
            if (!IsStarted)
            {
                throw new Exception("Not started");
            }

            Engine.Stop();
        }

        public void TurnLeft()
        {
            throw new NotImplementedException();
        }

        public void TurnRight()
        {
            throw new NotImplementedException();
        }

        public void Accellerate()
        {
            throw new NotImplementedException();
        }

        public void Decellerate()
        {
            throw new NotImplementedException();
        }
    }
}
