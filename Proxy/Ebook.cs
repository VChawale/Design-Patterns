using System;
namespace Design_Patterns.Proxy
{
    public class Ebook : IEbook
    {
        private string fileName;

        public Ebook(string fileName)
        {
            this.fileName = fileName;
            load();
        }

        private void load()
        {
            Console.WriteLine("Loading eBook.." + fileName);
        }

        public void show()
        {
            Console.WriteLine("Showing eBook.." + fileName);
        }

        public string getFileName()
        {
            return fileName;
        }
    }
}