namespace Design_Patterns.Proxy
{
    public class EbookProxy : IEbook
    {

        private string fileName;

        private Ebook ebook;

        public EbookProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public string getFileName()
        {
            return fileName;
        }

        public void show()
        {
            if(ebook==null)
            {
                ebook = new Ebook(fileName);
            }

            ebook.show();
        }
    }
}