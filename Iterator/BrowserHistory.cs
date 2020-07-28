using System;
using System.Collections.Generic;
using Design_Patterns.Iterator;

namespace Design_Patterns.Iterator
{
    public class BrowserHistory
    {
        private List<String> urls = new List<String>();

        public IIterator createIterator()
        {
            return new ListIterator(this);
        }

        public void push(string url)
        {
            urls.Add(url);
        }

        public string Pop(string url)
        {
            int lastIndex = urls.Count - 1;
            var lastItem = urls[lastIndex];
            urls.Remove(lastItem);
            return lastItem;
        }

        public class ListIterator : IIterator
        {
            private BrowserHistory history;
            private int index;
            public ListIterator(BrowserHistory history)
            {
                this.history = history;
            }

            public string Current()
            {
                return history.urls[index];
            }

            public bool HasNext()
            {
                return (index < history.urls.Count);
            }

            public void Next()
            {
                index++;
            }
        }
    }
}