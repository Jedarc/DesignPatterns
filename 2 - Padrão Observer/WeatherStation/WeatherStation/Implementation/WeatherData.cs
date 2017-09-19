using System;
using System.Collections.Generic;
using System.Text;
using WeatherStation.Interfaces;
using WeatherStation.SuperClass;

namespace WeatherStation.Implementation
{
    public class WeatherData : Observable
    {
        private double temperature;
        private double humidity;
        private double pressure;

        private void MeasurementsChanged()
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

        public double GetTemperature()
        {
            return this.temperature;
        }
        public double GetHumidity()
        {
            return this.humidity;
        }
        public double GetPressure()
        {
            return this.pressure;
        }
    }
}
