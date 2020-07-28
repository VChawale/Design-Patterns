using System;
namespace Design_Patterns.Strategy
{
    public class JpegCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Applying JPEG Compressor on.."+ fileName);
        }
    }
}