using System;

namespace CascadingBridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(Cascading) Bridge pattern");

            TV tv = new TV();
            Remote remote = new Remote(tv);
            remote.ChannelUp();

            Radio radio = new Radio();
            AdvancedRemote myRemote = new AdvancedRemote(radio);
            myRemote.ChannelUp();
            myRemote.mute();

            SuperAdvancedRemote sar = new SuperAdvancedRemote(tv);
            sar.ChannelUp();
            sar.mute();
            sar.RecordProgram();

            Console.WriteLine("===================================");

            Button button = new Button(remote);
            button.ClickUpButton();
        }
    }
}
