using System;
using System.Collections.Generic;
using System.Text;

namespace CascadingBridgePattern
{
    public class Button
    {
        private Remote remote;

        public Button(Remote remote)
        {
            this.remote = remote;
        }

        public void ClickUpButton()
        {
            Console.WriteLine("Chanel Up button");
            remote.ChannelUp();
        }

        public void ClickDownButton()
        {
            Console.WriteLine("Cliecked down");
        }
    }
}
