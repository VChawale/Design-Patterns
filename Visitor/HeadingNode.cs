using System;
namespace Design_Patterns.Visitor
{
    public class HeadingNode : IHtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}