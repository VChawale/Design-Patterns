using System.Collections.Generic;

namespace Design_Patterns.Mediator
{
    public abstract class UIControl
    {
        private List<IObserver> observerList = new List<IObserver>();
        public void Attach(IObserver observer)
        {

        }

        protected void NotifyObservers()
        {
            foreach (IObserver obs in observerList)
            {
                obs.Update();
            }
        }
    }
}