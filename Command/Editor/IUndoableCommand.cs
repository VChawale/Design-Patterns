namespace Design_Patterns.Command.Editor
{
    public interface IUndoableCommand : ICommand
    {
         public void UnExecute();
    }
}