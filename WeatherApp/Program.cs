using AutoMapper;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherApp.Repository;
using WeatherApp.Repository.IWeatherRepository;
using WeatherApp.Service;

namespace WeatherApp
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.Write("Open Weather Client \nCity: ");
            string City = Console.ReadLine();
            WeatherBL objWeatherBL = new WeatherBL();
            var WeatherReport = objWeatherBL.GetWeatherDetailsAsync(City);
            var data = WeatherReport.Result.Data;
            if (data != null)
            {
                Console.WriteLine("Temp: {0}\nFeels Like: {1}\nPressure: {2}\nHumidity: {3}", data.Temp, data.FeelsLike, data.Pressure, data.Humidity);
            }
            else
            {
                Console.WriteLine("City Not Found");
            }
            Console.WriteLine("\nPress any Key to Exit...");
            Console.ReadLine();
        }
    }
}
