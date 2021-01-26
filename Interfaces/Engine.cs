using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Engine : IEngine
    {
        public bool IsStarted { get; set; }

        public string Name { get; set; }

        public void Start()
        {
            IsStarted = true;
        }


        public void Stop()
        {
            IsStarted = false;
        }
    }
}
