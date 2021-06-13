namespace Design_Patterns.Bridge
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device)
        {
        }

        public void setChannel(int number)
        {
           base.device.setChannel(number);
        }
    }
}