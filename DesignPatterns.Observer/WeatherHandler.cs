using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class WeatherHandler : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        private WeatherInfo weatherInfo = new WeatherInfo(0, 0);

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(this.weatherInfo);
            }
        }

        public WeatherInfo WeatherInfo
        {
            get
            {
                return weatherInfo;
            }
            set
            {
                weatherInfo = value;
                NotifyObservers();
            }
        }
    }
}
