namespace Design_Patterns.Strategy
{
    public class ImageStorage
    {
        public void StoreImage(ICompressor compressor, IFilter filter, string fileName)
        {
            compressor.Compress(fileName);
            filter.ApplyFilter(fileName);
        }
    }
}