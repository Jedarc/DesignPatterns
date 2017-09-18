using System;
using System.Collections.Generic;
using System.Text;
using WeatherStation.Interfaces;

namespace WeatherStation.Implementation
{
    public class WeatherData : Subject
    {
        private List<Observer> observerList;
        private double temperature;
        private double humidity;
        private double pressure;

        public WeatherData()
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
            for (int observerIndex = 0; observerIndex < observerList.Count; observerIndex++)
            {
                var observer = observerList[observerIndex];
                observer.Update(temperature, humidity, pressure);
            }
        }

        protected void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            MeasurementsChanged();
        }

    }
}
