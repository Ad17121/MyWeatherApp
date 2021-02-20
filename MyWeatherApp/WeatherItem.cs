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

        public WeatherItem(string title, Image weatherImage, int temperature, int windDirection, int windSpeed, int time)
        {
            this.Title = title;
            this.WeatherImage = weatherImage;
            this.Temperature = temperature;
            this.WindDirection = windDirection;
            this.WindSpeed = windSpeed;
            this.Time = time;

        }
    }
}
