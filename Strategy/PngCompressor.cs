using System;
namespace Design_Patterns.Strategy
{
    public class PngCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Applying Png compressor on.. " + fileName);
        }
    }
}