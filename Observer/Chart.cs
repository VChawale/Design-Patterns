using System;
namespace Design_Patterns.Observer
{
    public class Chart : IObserver
    {
        private DataSource dataSource = new DataSource();

        public Chart(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("Chart got notified" + dataSource.Value);
        }
    }
}