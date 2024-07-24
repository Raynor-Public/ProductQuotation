using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Domain.Abstraction.Repository
{
    public interface IWeatherForeCastRepo
    {
        void CreateWeather();
        void UpdateWeather();
        void DeleteWeather();
        void DeleteWeatherForecast();
        void UpdateWeatherForecastForecasts();
        void GetWeatherForcast(string id);
        void WeatherForecastById(string id);
        void WeatherForeCast();
        
    }
}
