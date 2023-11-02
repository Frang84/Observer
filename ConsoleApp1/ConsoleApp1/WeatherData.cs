using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class WeatherData : Subject
    {

        public int _humidity;
        public int _temperature;
        public int _pressure;
        public WeatherData(int humidity, int temperature, int pressure) 
        {
            _humidity = humidity;
            _temperature = temperature;
            _pressure = pressure;
        }
        public void SetParams(int humidity, int temperature,int pressure)
        {
            _humidity = humidity;   
            _temperature = temperature;
            _pressure = pressure;
            this.SetState(0);
        }

        public void GetHumidity()
        {
            Console.WriteLine("Humidity: " + this._humidity +"%");
        }
        public void GetTemperature()
        {
            Console.WriteLine("Temperature: " + this._temperature);
        }
        public void GetPressure()
        {
            Console.WriteLine("Pressure: " + this._pressure);
        }
       

    }
}
