namespace Design_Patterns.Decorator
{
    public class CompressedCloudStream : IStream
    {

        private IStream stream;

        public CompressedCloudStream(IStream stream)
        {
            this.stream = stream;
        }

        public void write(string data)
        {
            var compressed = compressData(data);
            stream.write(compressed);

        }

        private string compressData(string data)
        {
            return data.Substring(0, 3);
        }
    }
}