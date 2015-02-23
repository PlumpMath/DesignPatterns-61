using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.DisplayElements
{
    public abstract class DisplayElementBase : IObserver, IDisplayElement, IDisposable
    {
        protected ISubject subject;

        public DisplayElementBase(ISubject subject)
        {
            this.subject = subject;
            subject.RegisterObserver(this);
        }

        public abstract void Update(WeatherInfo weatherInfo);

        public abstract void Display();

        public void Unsubscribe()
        {
            subject.RemoveObserver(this);
        }

        public void Dispose()
        {
            this.Unsubscribe();
        }
    }
}
