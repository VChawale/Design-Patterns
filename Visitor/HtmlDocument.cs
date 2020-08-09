using System.Collections.Generic;

namespace Design_Patterns.Visitor
{
    public class HtmlDocument
    {
        private List<IHtmlNode> nodes = new List<IHtmlNode>();

        public void Add(IHtmlNode node)
        {
            nodes.Add(node);
        }

        public void ExecuteOperation(IOperation operation)
        {
            foreach (var node in nodes)
            {
                node.Execute(operation);
            }
        }
    }
}