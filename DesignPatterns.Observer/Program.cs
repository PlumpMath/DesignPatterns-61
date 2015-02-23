using DesignPatterns.Observer.DisplayElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    /// <summary>
    /// The observer pattern defines a one-to-many dependency between objects
    /// so that when one object changes state, all of its dependents are notified and updated automatically.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var weatherHandler = new WeatherHandler();
            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherHandler);
            var statisticsDisplay = new StatisticsDisplay(weatherHandler);

            weatherHandler.WeatherInfo = new WeatherInfo(5, 5);
            Console.WriteLine();
            weatherHandler.WeatherInfo = new WeatherInfo(10, 6);
            Console.WriteLine();
            weatherHandler.WeatherInfo = new WeatherInfo(4, 3);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
