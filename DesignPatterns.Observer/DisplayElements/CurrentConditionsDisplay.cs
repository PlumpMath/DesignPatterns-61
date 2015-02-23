using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.DisplayElements
{
    public class CurrentConditionsDisplay : DisplayElementBase
    {
        public CurrentConditionsDisplay(ISubject subject) : base(subject) { }

        public int Temperature { get; private set; }

        public int Humidity { get; private set; }

        public override void Update(WeatherInfo weatherInfo)
        {
            this.Temperature = weatherInfo.Temperature;
            this.Humidity = weatherInfo.Humidity;
            this.Display();
        }

        public override void Display()
        {
            Console.WriteLine("Temperature = {0}\nHumidity = {1}", this.Temperature, this.Humidity);
        }
    }
}
