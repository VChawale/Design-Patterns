using System;
namespace Design_Patterns.Visitor
{
    public class PlainTextOperation : IOperation
    {
        public void Apply(AnchorNode node)
        {
           Console.WriteLine("plaintext-anchor");
        }

        public void Apply(HeadingNode node)
        {
            Console.WriteLine("plaintext-heading");
        }
    }
}