using System;
namespace Design_Patterns.Observer
{
    public class Sheet : IObserver
    {
        private DataSource dataSource = new DataSource();

        public Sheet(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("sheet got notified" + dataSource.Value);
        }
    }
}