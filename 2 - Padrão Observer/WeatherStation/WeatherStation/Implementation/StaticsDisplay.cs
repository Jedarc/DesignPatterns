using System;
using System.Collections.Generic;
using System.Text;
using WeatherStation.Interfaces;
using WeatherStation.SuperClass;

namespace WeatherStation.Implementation
{
    public class StaticsDisplay : Observer, DisplayElement
    {
        private double maxTemperature;
        private double minTemperature;
        private double temperatureSum;
        private int readingsCount;
        private Observable observable;

        public StaticsDisplay(Observable observable)
        {
            this.observable = observable;
            temperatureSum = 0;
            maxTemperature = -100;
            minTemperature = 100;
            observable.RegisterObserver(this);
        }

        public void Update(Observable observable)
        {
            if (observable is WeatherData)
            {
                var weatherData = (WeatherData)observable;

                var temperature = weatherData.GetTemperature();

                temperatureSum += temperature;
                readingsCount++;

                if (temperature > maxTemperature)
                {
                    maxTemperature = temperature;
                }

                if (temperature < minTemperature)
                {
                    minTemperature = temperature;
                }
            }
            
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature = {temperatureSum / readingsCount} / {maxTemperature} / {minTemperature}");
        }

    }
}
