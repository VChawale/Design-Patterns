
using Design_Patterns.Adapter.AvaFilters;

namespace Design_Patterns.Adapter
{
    public class CaramelFilter : IFilter
    {
        private readonly Caramel caramel;

        public CaramelFilter(Caramel caramel)
        {
            this.caramel = caramel;
        }

        public void Apply(Image image)
        {
            caramel.init();
            caramel.render(image);
        }
    }
}