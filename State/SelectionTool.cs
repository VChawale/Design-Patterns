using System;
namespace Design_Patterns.State
{
    public class SelectionTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Selection Tool");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a dashed rectangle");
        }
    }
}