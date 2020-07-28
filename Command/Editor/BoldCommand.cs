namespace Design_Patterns.Command.Editor
{
    public class BoldCommand : IUndoableCommand
    {

        private string prevContent;
        private History history;
        private HtmlDocument document;

        public BoldCommand(History history, HtmlDocument document)
        {
            this.history = history;
            this.document = document;
        }

        public void Execute()
        {
            prevContent = document.Content;
            document.MakeBold();
            history.Push(this);
        }

        public void UnExecute()
        {
            document.Content = prevContent;
        }
    }
}