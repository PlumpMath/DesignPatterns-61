using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class WeatherInfo
    {
        public WeatherInfo(int temperature, int humidity)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
        }

        public int Temperature { get; private set; }

        public int Humidity { get; private set; }
    }
}
