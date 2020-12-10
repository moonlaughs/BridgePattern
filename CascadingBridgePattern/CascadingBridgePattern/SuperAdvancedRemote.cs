using System;
using System.Collections.Generic;
using System.Text;

namespace CascadingBridgePattern
{
    public class SuperAdvancedRemote : AdvancedRemote
    {
        public SuperAdvancedRemote(IDevice device) : base(device)
        {
        }

        public void RecordProgram()
        {
            Console.WriteLine("Super advanced remote recording program...");
        }
    }
}
