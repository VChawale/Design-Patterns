using System;
namespace Design_Patterns.Visitor
{
    public class HighLightOperation : IOperation
    {
        public void Apply(AnchorNode node)
        {
            Console.WriteLine("highlight-anchor");
        }

        public void Apply(HeadingNode node)
        {
            Console.WriteLine("highlight-Heading");
        }
    }
}