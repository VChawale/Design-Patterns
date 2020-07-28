using System.Collections.Generic;

namespace Design_Patterns.Command.Editor
{
    public class History
    {
        List<IUndoableCommand> commandList = new List<IUndoableCommand>();

        public void Push(IUndoableCommand command)
        {
            commandList.Add(command);
        }

        public IUndoableCommand Pop()
        {
            int lastIndex = commandList.Count - 1;
            return commandList[lastIndex];
        }

        public int size()
        {
            return commandList.Count;
        }
    }
}