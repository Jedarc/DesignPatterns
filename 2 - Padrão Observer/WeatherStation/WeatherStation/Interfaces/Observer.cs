using System;
using System.Collections.Generic;
using System.Text;
using WeatherStation.SuperClass;

namespace WeatherStation.Interfaces
{
    public interface Observer
    {
        void Update(Observable observable);
    }
}
