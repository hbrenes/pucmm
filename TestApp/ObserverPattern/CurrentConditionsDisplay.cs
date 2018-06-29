using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : IObserver
    {
        private float temperature;
        private float humidity;

        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject subject)
        {
            this.weatherData = subject;
            this.weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;

            Console.WriteLine($"Current Conditions \nTemperature: {this.temperature}\nHumidity: {this.humidity}");
        }
    }
}
