using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.DisplayElements
{
    class StatisticsDisplay : DisplayElementBase
    {
        public StatisticsDisplay(ISubject subject) : base(subject) { }

        public int? MaxTemperature { get; private set; }

        public int? MinTemperature { get; private set; }

        public int? MaxHumidity { get; private set; }

        public int? MinHumidity { get; private set; }

        public override void Update(WeatherInfo weatherInfo)
        {
            this.MaxTemperature = this.MaxTemperature.HasValue ? Math.Max(this.MaxTemperature.Value, weatherInfo.Temperature) : weatherInfo.Temperature;
            this.MinTemperature = this.MinTemperature.HasValue ? Math.Min(this.MinTemperature.Value, weatherInfo.Temperature) : weatherInfo.Temperature;
            this.MaxHumidity = this.MaxHumidity.HasValue ? Math.Max(this.MaxHumidity.Value, weatherInfo.Humidity) : weatherInfo.Humidity;
            this.MinHumidity = this.MinHumidity.HasValue ? Math.Min(this.MinHumidity.Value, weatherInfo.Humidity) : weatherInfo.Humidity;
            this.Display();
        }

        public override void Display()
        {
            Console.WriteLine("MaxTemperature: {0}\nMinTemperature: {1}\nMaxHumidity: {2}\nMinHumidity: {3}", this.MaxTemperature, this.MinTemperature, this.MaxHumidity, this.MinHumidity);
        }
    }
}
