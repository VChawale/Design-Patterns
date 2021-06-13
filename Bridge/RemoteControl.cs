using Design_Patterns.Bridge;
namespace Design_Patterns.Bridge
{
    public class RemoteControl
    {

        protected IDevice device;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public void turnOn()
        {
            device.turnOn();
        }

        public void turnOff()
        {
            device.turnOff();
        }
    }
}