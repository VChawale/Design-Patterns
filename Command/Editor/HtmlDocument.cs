namespace Design_Patterns.Command.Editor
{
    public class HtmlDocument
    {
        private string content;

        public string Content
        {
            get { return content; }
            set
            {
                content = value;
            }
        }

        public void MakeBold()
        {
            content = "<b>" + content + "</b>";
        }
    }
}