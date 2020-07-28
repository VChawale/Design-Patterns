namespace Design_Patterns.Iterator
{
    public interface IIterator
    {
         public bool HasNext();
         public string Current();

         void  Next();
    }
}