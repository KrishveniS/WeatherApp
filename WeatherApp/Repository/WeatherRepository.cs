using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Model;
using WeatherApp.Repository.IWeatherRepository;

namespace WeatherApp.Repository
{
    public class WeatherRepository : IWeatherRepo
    {
        public WeatherRepository()
        {

        }
        public Task<Weather> GetWeather(string CityName)
        {
            Weather weather = new();
            string APIkey = "9b9bea2d75a107e39817969422f605db";
            string url = String.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric", CityName, APIkey);

            JObject response = JObject.Parse(new WebClient().DownloadString(url));
            if (response.SelectToken("cod").ToString().Equals("200"))
            {
                weather.City = response.SelectToken("name").ToString();
                weather.Temp = response.SelectToken("main.temp").ToString() + " Celsius";
                weather.FeelsLike = response.SelectToken("main.feels_like").ToString() + " Celsius";
                weather.Humidity = response.SelectToken("main.humidity").ToString() + " %";
                weather.Pressure = response.SelectToken("main.pressure").ToString() + " hPa";
            }
            
            return Task.FromResult(weather);
        }
    

    }
}
    

