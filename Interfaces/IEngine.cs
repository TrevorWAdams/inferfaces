using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IEngine
    {
        string Name { get; set; }
        bool IsStarted { get; set; }
        void Start();
        void Stop();
    }
}
