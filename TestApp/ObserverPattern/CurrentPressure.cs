using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class CurrentPressure : IObserver
    {
        private float pressure;

        private ISubject weatherData;

        public CurrentPressure(ISubject subject)
        {
            this.weatherData = subject;
            this.weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.pressure = pressure;

            Console.WriteLine($"Current Pressure: {this.pressure}");
        }
    }
}
