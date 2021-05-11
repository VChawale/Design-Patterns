namespace Design_Patterns.Adapter
{
    public class ImageView
    {
        private readonly Image image;

        public ImageView(Image image)
        {
            this.image = image;
        }

        public void apply(IFilter filter)
        {
            filter.Apply(image);
        }
    }
}