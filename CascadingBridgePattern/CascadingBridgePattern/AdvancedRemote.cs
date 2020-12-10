using System;
using System.Collections.Generic;
using System.Text;

namespace CascadingBridgePattern
{
    public class AdvancedRemote : Remote
    {
        public AdvancedRemote(IDevice device) : base(device)
        {
        }

        public void mute()
        {
            Console.WriteLine("Advanced Remote muted");
        }
    }
}
