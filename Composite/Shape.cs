using System;
namespace Design_Patterns.Composite
{
    public class Shape : IComponent
    {
        public void RenderComponent()
        {
            Console.WriteLine("Rendering Shape");
        }
    }
}