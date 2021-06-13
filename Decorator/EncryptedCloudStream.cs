namespace Design_Patterns.Decorator
{
    public class EncryptedCloudStream : IStream
    {
        private IStream stream;

        public EncryptedCloudStream(IStream stream)
        {
            this.stream = stream;
        }

        public void write(string data)
        {
           var encryptedData = encryptData(data);
           stream.write(encryptedData);
        }

        private string encryptData(string data)
        {
            return "#@#%@%#@#^@&&&%%%%!";
        }
    }
}