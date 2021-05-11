using System;
namespace Design_Patterns.Adapter
{
    public class VividFilter : IFilter 
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Applying Vivid Filter");
        }
    }
}