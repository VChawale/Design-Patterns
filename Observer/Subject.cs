using System.Collections.Generic;

namespace Design_Patterns.Observer
{
    public class Subject
    {
        private List<IObserver> observers = new List<IObserver>();
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver obs in observers)
            {
                obs.Update();
            }
        }
    }
}