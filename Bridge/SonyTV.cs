using System;
namespace Design_Patterns.Bridge
{
    public class SonyTV : IDevice
    {
        public void turnOn()
        {
            Console.WriteLine("SonyTV : Turning ON");

        }

        public void turnOff()
        {
            Console.WriteLine("SonyTV : Turning OFF");
        }

        public void setChannel(int number)
        {
            Console.WriteLine("SonyTV : Setting Channel "+ number);
        }

    }
}