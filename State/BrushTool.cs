using System;
namespace Design_Patterns.State
{
    public class BrushTool : ITool
    {
        public void MouseDown()
        {
           Console.WriteLine("Brush Icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a Line");
        }
    }
}