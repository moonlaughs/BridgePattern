using System;
using System.Collections.Generic;
using System.Text;

namespace CascadingBridgePattern
{
    public class Radio : IDevice
    {
        public void disable()
        {
            Console.WriteLine("Radio disabled");
        }

        public void enable()
        {
            Console.WriteLine("Radio enabled");
        }

        public void isEnabled()
        {
            Console.WriteLine("Radio is enabled");
        }
    }
}
