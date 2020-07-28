namespace Design_Patterns.Mediator
{
    public class ArticlesDialogBox
    {
        private ListBox articlesListBox = new ListBox();
        private TextBox textBox = new TextBox();
        private Button saveButton = new Button();

        public ArticlesDialogBox()
        {
            ArticlesObserver observer = new ArticlesObserver();
            //articlesListBox.Attach(this::ArticleSelected);
        }

        public class ArticlesObserver : IObserver
        {
            public void Update()
            {
               // this.ArticleSelected();
            }
        }

        public void SimulateUserInteraction()
        {
            articlesListBox.Selection = "Article 1";
            textBox.Content = "";
            textBox.Content = "Article 2";
            System.Console.WriteLine("TextBox:" + textBox.Content);
            System.Console.WriteLine("Button:" + saveButton.IsEnabled);
        }
        public void TitleChanged()
        {
            var content = textBox.Content;
            bool isEmpty = string.IsNullOrEmpty(content);
            saveButton.IsEnabled = !isEmpty;
        }

        public void ArticleSelected()
        {
            textBox.Content = articlesListBox.Selection;
            saveButton.IsEnabled = true;
        }
    }


}