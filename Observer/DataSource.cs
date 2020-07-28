namespace Design_Patterns.Observer
{
    public class DataSource : Subject
    {
        private int value;

        public int Value
        {
            get { return value; }
            set
            {
                this.value = value;
                NotifyObservers();
            }
        }


    }
}