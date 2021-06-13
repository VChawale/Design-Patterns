using System;
namespace Design_Patterns.Bridge
{
    public class SamsungTV : IDevice
    {
        public void setChannel(int number)
        {
             Console.WriteLine("SAMSUNG TV: Setting channel "+ number);
        }

        public void turnOff()
        {
            Console.WriteLine("SAMSUNG TV: Turning OFF");
        }

        public void turnOn()
        {
            Console.WriteLine("SAMSUNG TV: Turning ON");
        }
    }
}