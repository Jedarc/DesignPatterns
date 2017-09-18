using System;
using System.Collections.Generic;
using System.Text;
using WeatherStation.Interfaces;

namespace WeatherStation.Implementation
{
    public class StaticsDisplay : Observer, DisplayElement
    {
        private double maxTemperature;
        private double minTemperature;
        private double temperatureSum;
        private int readingsCount;
        private WeatherData weatherData;

        public StaticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            temperatureSum = 0;
            maxTemperature = -100;
            minTemperature = 100;
            weatherData.RegisterObserver(this);
        }

        public void Update(double temperature, double humidity, double pressure)
        {
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
            
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature = {temperatureSum / readingsCount} / {maxTemperature} / {minTemperature}");
        }

    }
}
