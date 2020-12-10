using System;
using System.Collections.Generic;
using System.Text;

namespace CascadingBridgePattern
{
    public class TV : IDevice
    {
        public void disable()
        {
            Console.WriteLine("TV disabled");
        }

        public void enable()
        {
            Console.WriteLine("TV enabled");
        }

        public void isEnabled()
        {
            Console.WriteLine("TV is enabled");
        }
    }
}
