using System;
using System.Collections.Generic;
using System.Text;
using WeatherStation.Interfaces;
using WeatherStation.SuperClass;

namespace WeatherStation.Implementation
{
    public class ForecastDisplay : Observer, DisplayElement
    {
        private double currentPressure;
        private double lastPressure;
        private Observable observable;

        public ForecastDisplay(Observable observable)
        {
            this.observable = observable;
            currentPressure = 0;
            lastPressure = 0;
            observable.RegisterObserver(this);
        }

        public void Update(Observable observable)
        {
            if (observable is WeatherData)
            {
                var weatherData = (WeatherData)observable;

                lastPressure = currentPressure;
                currentPressure = weatherData.GetPressure();
            }
            
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
