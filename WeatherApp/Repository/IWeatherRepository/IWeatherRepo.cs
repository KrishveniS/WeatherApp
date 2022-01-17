using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Model;

namespace WeatherApp.Repository.IWeatherRepository
{
    public interface IWeatherRepo
    {
        Task<Weather> GetWeather(string CityName);
    }
}
