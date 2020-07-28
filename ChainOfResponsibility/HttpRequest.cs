namespace Design_Patterns.ChainOfResponsibility
{
    public class HttpRequest
    {
        private string userName;
        private string password;
        public string UserName { get => userName; }
        public string Password { get => password; }
        public HttpRequest(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }


    }
}