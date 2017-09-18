using System;
using WeatherStation.Implementation;

namespace WeatherStation
{
    public static class WeatherStation
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();

            var currentDisplay = new CurrentConditionsDisplay(weatherData);
            var staticsDisplay = new StaticsDisplay(weatherData);
            var forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4);
            weatherData.SetMeasurements(82, 70, 29.2);
            weatherData.SetMeasurements(78, 90, 29.2);

            Console.ReadKey();
        }
    }
}
