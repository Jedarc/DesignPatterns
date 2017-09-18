using System;
using System.Collections.Generic;
using System.Text;
using WeatherStation.Interfaces;

namespace WeatherStation.Implementation
{
    public class ForecastDisplay : Observer, DisplayElement
    {
        private double currentPressure;
        private double lastPressure;
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            currentPressure = 0;
            lastPressure = 0;
            weatherData.RegisterObserver(this);
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;

            Display();
        }

        public void Display()
        {
            Console.Write("Forecast: ");
            if(currentPressure > lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if(currentPressure == lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
            
        }
    }
}
