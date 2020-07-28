using System;
namespace Design_Patterns.Strategy
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void ApplyFilter(string fileName)
        {
            Console.WriteLine("Applying Black and White filter on.." + fileName);
        }
    }
}