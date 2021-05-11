using System;
namespace Design_Patterns.Adapter.AvaFilters
{
    public class Caramel
    {
        public void init()
        {

        }

        public void render(Image image)
        {
            Console.WriteLine("Applying Caramel Filter");
        }
    }
}