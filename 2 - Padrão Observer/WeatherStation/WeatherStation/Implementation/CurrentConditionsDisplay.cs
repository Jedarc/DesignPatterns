using System;
using System.Collections.Generic;
using System.Text;
using WeatherStation.Interfaces;
using WeatherStation.SuperClass;

namespace WeatherStation.Implementation
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private double temperature;
        private double humidity;
        private Observable observable;

        public CurrentConditionsDisplay(Observable observable)
        {
            this.observable = observable;
            observable.RegisterObserver(this);
        }

        public void Update(Observable observable)
        {
            if (observable is WeatherData)
            {
                var weatherData = (WeatherData)observable;

                this.temperature = weatherData.GetTemperature();
                this.humidity = weatherData.GetHumidity();
            }

            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");
        }

    }
}
