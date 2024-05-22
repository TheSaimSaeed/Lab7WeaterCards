using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Lab7WeaterCards.Pages.Weather;
namespace Data
{
	

	public class WeatherForecastService
	{
		public WeatherForecastService() { }
		private static readonly string[] Summaries = new[]
		{
			"Cloudy", "Rainy", "Sunny"
		};
        
        public async Task<IEnumerable<WeatherForecast>> GetForecastAsync()
		{
			var rng = new Random();
			var forecasts = new List<WeatherForecast>();

			for (int i = 0; i < 5; i++)
			{
                var forecastDate = DateOnly.FromDateTime(DateTime.Today.AddDays(i));
                


                var temperatureC = rng.Next(-20, 55); 
				var summary = Summaries[rng.Next(Summaries.Length)]; 

				forecasts.Add(new WeatherForecast
				{
					Date = forecastDate,
					TemperatureC = temperatureC,
					Summary = summary,
				});
			}

			

			return forecasts;
		}
	}
}
