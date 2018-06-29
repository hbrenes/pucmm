using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData wd = new WeatherData();

            var cc = new CurrentConditionsDisplay(wd);
            var t = new CurrentPressure(wd);

            wd.Temperature = 30;
            wd.Pressure = 989;

            Console.Read();

        }
    }
}
