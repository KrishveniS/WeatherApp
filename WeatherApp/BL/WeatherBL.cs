using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using WeatherApp.Model;
using WeatherApp.Service.WeatherService;
using WeatherApp.DTOs;
using WeatherApp.ServiceResponse;
using WeatherApp.Repository.IWeatherRepository;
using AutoMapper;
using WeatherApp.Repository;

namespace WeatherApp.Service
{
    public class WeatherBL : IWeatherBL
    {        
        public WeatherBL()
        {
            
        }

        public async Task<ServiceResponse<WeatherDTO>> GetWeatherDetailsAsync(string CityName)
        {
            ServiceResponse<WeatherDTO> _response = new();
            WeatherRepository weatherRepository = new WeatherRepository();

            try
            {
                var weather = await weatherRepository.GetWeather(CityName);
                
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Weather, WeatherDTO>());
                var mapper = new Mapper(config);

                var _weatherDTO = mapper.Map<WeatherDTO>(weather);

                _response.Data = _weatherDTO;

            }
            catch(Exception ex)
            {
                _response.Data = null;
                _response.Message = Convert.ToString(ex.Message);
            }
            return _response;
        }
    }
}


    
        
        
    

