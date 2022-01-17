using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.DTOs;
using WeatherApp.ServiceResponse;

namespace WeatherApp.Service.WeatherService
{
    public interface IWeatherBL
    {
        Task<ServiceResponse<WeatherDTO>> GetWeatherDetailsAsync(string CityName);
    }
}
