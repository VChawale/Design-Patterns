namespace Design_Patterns.ChainOfResponsibility
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {

        }

        public override bool DoHandle(HttpRequest request)
        {
             var isValid = (request.UserName.Equals("admin") && (request.Password.Equals("1234")));
            System.Console.WriteLine("Authentication");
            return !isValid;
        }
    }
}