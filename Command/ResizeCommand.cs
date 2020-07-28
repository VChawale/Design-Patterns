using System;
using Design_Patterns.Command.FX;

namespace Design_Patterns.Command
{
    public class ResizeCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Resize Image");
        }
    }
}