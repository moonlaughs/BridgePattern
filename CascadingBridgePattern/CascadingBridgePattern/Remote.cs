using System;
using System.Collections.Generic;
using System.Text;

namespace CascadingBridgePattern
{
    public class Remote
    {
        private IDevice device;

        public Remote(IDevice device)
        {
            this.device = device;
        }

        public void ChannelUp()
        {
            device.enable();
            Console.WriteLine("DEvice enabled");
            Console.WriteLine("REmote channel up");
        }

        public void ChannelDown()
        {
            Console.WriteLine("REmote channel down");
        }
    }
}
