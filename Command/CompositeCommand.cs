using Design_Patterns.Command.FX;
using System;
using System.Collections.Generic;

namespace Design_Patterns.Command
{
    public class CompositeCommand : ICommand
    {
        List<ICommand> commandList = new List<ICommand>();

        public void Add(ICommand command)
        {
            commandList.Add(command);
        }

        public void Execute()
        {
           foreach(ICommand command in commandList)
           {
               command.Execute();
           }
        }
    }
}