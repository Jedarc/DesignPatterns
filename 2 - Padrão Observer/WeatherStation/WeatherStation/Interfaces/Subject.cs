using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation.Interfaces
{
    public interface Subject
    {
        bool RegisterObserver(Observer observer);
        bool RemoveObserver(Observer observer);
        void NotifyObservers();
    }
}
