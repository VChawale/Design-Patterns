namespace Design_Patterns.Memento
{
    public class Editor
    {
        private string content;

        public EditorState CreateState()
        {

            return new EditorState(content);
        }

        public void Restore(EditorState state)
        {
            content = state.Content;
        }

        public string GetContent()
        {
            return content;
        }

        public void SetContent(string content)
        {
            this.content = content;
        }
    }
}