using System;
namespace Design_Patterns.Decorator
{
    public class CloudStream : IStream
    {


        public void write(string data)
        {
            Console.WriteLine("Storing Data" + data);
        }
    }
}