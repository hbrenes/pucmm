using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class WeatherData : ISubject
    {
        List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public float Temperature
        {
            get => temperature;
            set
            {
                this.temperature = value;
                this.MeasurementsChanged();
            }
        }

        public float Humidity
        {
            get => humidity;
            set
            {
                this.humidity = value;
                this.MeasurementsChanged();
            }
        }

        public float Pressure
        {
            get => pressure;
            set
            {
                this.pressure = value;
                this.MeasurementsChanged();
            }
        }

        public WeatherData()
        {
            this.observers = new List<IObserver>();
            this.temperature = 28;
            this.humidity = 40;
            this.Pressure = 1040;
        }

        private void MeasurementsChanged()
        {
            this.NotifyObservers(this.observers);
        }


        public void RegisterObserver(IObserver o)
        {
            this.observers.Add(o);
            o.Update(this.temperature, this.humidity, this.pressure);
        }

        public void RemoveObserver(IObserver o)
        {
            this.observers.Remove(o);
        }

        public void NotifyObservers(List<IObserver> observers)
        {
            foreach (var o in observers)
            {
                o.Update(this.temperature, this.humidity, this.pressure);
            }
        }
    }
}
