using System;
namespace Design_Patterns.State
{
    public class EraserTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Erase Icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Erase something");
        }
    }
}