namespace Design_Patterns.ChainOfResponsibility
{
    public class WebServer
    {
        private Handler handler;

        public WebServer(Handler handler)
        {
            this.handler = handler;
        }

        public void Handle(HttpRequest request)
        {
            handler.Handle(request);
        }
    }
}