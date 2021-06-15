using System.Collections.Generic;

namespace Design_Patterns.Proxy
{
    public class Library
    {
        private Dictionary<string, IEbook> eBooks = new Dictionary<string, IEbook>();

        public void add(IEbook ebook)
        {
            eBooks.Add(ebook.getFileName(), ebook);
        }

        public void openEbook(string fileName)
        {
            eBooks[fileName].show();
        }
    }
}