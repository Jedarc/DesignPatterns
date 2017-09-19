using System;
using System.Collections.Generic;
using System.Text;
using WeatherStation.Interfaces;

namespace WeatherStation.SuperClass
{
    public class Observable : Subject
    {
        private List<Observer> observerList;

        public Observable()
        {
            observerList = new List<Observer>();
        }

        public bool RegisterObserver(Observer observer)
        {
            try
            {
                observerList.Add(observer);
                return true;
            }
            catch { }

            return false;
        }

        public bool RemoveObserver(Observer observer)
        {
            return observerList.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observerList)
            {
                observer.Update(this);
            }
        }
        
    }
}
