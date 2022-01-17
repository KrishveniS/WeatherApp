using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model
{
    public class Weather
    {
        public string City { get; set; }
        public string  Temp { get; set; }
        public string FeelsLike { get; set; }
        public string Pressure { get; set; }
        public string Humidity { get; set; }
        public string ErrResponse { get; set; }
    }
}
