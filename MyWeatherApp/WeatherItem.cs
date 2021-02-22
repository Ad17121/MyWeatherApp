using System.Drawing;

namespace MyWeatherApp
{
    public class WeatherItem
    {
        public string Title { get; set; }
        public Image WeatherImage { get; set; }
        public int Temperature { get; set; }
        public int WindDirection { get; set; }
        public int WindSpeed { get; set; }
        public int Time { get; set; }
        public string Weather { get; set; }
        public int Rain { get; set; }
        public int FeelsLike { get; set; }
        public int DewPoint { get; set; }
        public int Pressure { get; set; }
        public int Clouds { get; set; }
        public int MaxTemp { get; set; }
        public int MinTemp { get; set; }
        public string Sunset { get; set; }
        public string Sunrise { get; set; }


        public WeatherItem(string title, Image weatherImage, int temperature, int windDirection, int windSpeed, int time, string weather, int feelsLike, int dewpoint, int pressure, int clouds)
        {
            this.Title = title;
            this.WeatherImage = weatherImage;
            this.Temperature = temperature;
            this.WindDirection = windDirection;
            this.WindSpeed = windSpeed;
            this.Time = time;
            this.Weather = weather;
            this.FeelsLike = feelsLike;
            this.DewPoint = dewpoint;
            this.Pressure = pressure;
            this.Clouds = clouds;
        }

        public WeatherItem(string title, Image weatherImage, int temperature, int windDirection, int windSpeed, int time, string weather, int rain, int feelsLike, int dewpoint, int pressure, int clouds, int maxTemp, int minTemp, string sunSet, string sunRise)
            : this(title, weatherImage, temperature, windDirection, windSpeed, time, weather, feelsLike, dewpoint, pressure, clouds)
        {
            this.MaxTemp = maxTemp;
            this.MinTemp = minTemp;
            this.Sunrise = sunRise;
            this.Sunset = sunSet;
        }
    }
}
