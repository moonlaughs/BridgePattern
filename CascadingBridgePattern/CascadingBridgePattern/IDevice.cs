using System;
using System.Collections.Generic;
using System.Text;

namespace CascadingBridgePattern
{
    public interface IDevice
    {
        public void isEnabled();
        public void enable();
        public void disable();
    }
}
