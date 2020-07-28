using System;
namespace Design_Patterns.Mediator
{
    public class DialogBoxEventArgs : EventArgs
    {
        private ListBox articlesListBox = new ListBox();
        private TextBox textBox = new TextBox();
        private Button saveButton = new Button();

        public DialogBoxEventArgs(ListBox articlesListBox, TextBox textBox, Button saveButton)
        {
            this.articlesListBox = articlesListBox;
            this.textBox = textBox;
            this.saveButton = saveButton;
        }
    }
    public class ArticlesDialogBoxPublisher
    {
        public event EventHandler<DialogBoxEventArgs> ArticlesDiaglogBoxChanged;
    }
}