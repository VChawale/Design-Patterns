namespace Design_Patterns.Visitor
{
    public interface IHtmlNode
    {
         void Execute(IOperation operation);
    }
}