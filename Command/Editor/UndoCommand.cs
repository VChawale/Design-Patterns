namespace Design_Patterns.Command.Editor
{
    public class UndoCommand : ICommand
    {

        // this is getting implemented to replicate behavior of Undo Button in Menu you see, so this can be used anywhere with any
       private History history;

        public UndoCommand(History history)
        {
            this.history = history;
        }

        public void Execute()
        {
            if (history.size() > 0)
            history.Pop().UnExecute();
        }
    }
}