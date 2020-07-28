using Design_Patterns.Command.FX;
using System;
namespace Design_Patterns.Command
{
    public class BlackAndWhiteFilterCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Black an White filter");
        }
    }
}