using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation.Interfaces
{
    public interface Observer
    {
        void Update(double temperature, double humidity, double pressure);
    }
}
