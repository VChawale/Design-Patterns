namespace Design_Patterns.Command.FX
{
    public class Button
    {
       public void Click(ICommand command)
       {
           command.Execute();
       }
    }
}