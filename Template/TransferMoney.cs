using System;
namespace Design_Patterns.Template
{
    public class TransferMoney : Task
    {
        protected override void doExecute()
        {
            Console.WriteLine("Money Transferred!");
        }
    }
}