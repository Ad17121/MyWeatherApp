using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WeatherControl;

namespace MyWeatherApp
{

    public partial class Form1 : Form
    {
        private string geoApiKey = "pk.eyJ1IjoiYWQxNzEyIiwiYSI6ImNra3M1b21hNjBhODYzMHA2MW10NDkzMXYifQ.b5jn2CIw0_T5hUk2QgXQkQ";
        private string weatherApiKey = "218af08b84d7c75ec1bc3a981de5b72a";
        private ObservableCollection<string> locations;
        private string filePath = Environment.CurrentDirectory + @"\locations.txt";
        private string mapUrl = "https://www.google.com/maps/search/?api=1&output=embed&query=";
        private MyWeather weather;

        public Form1()
        {
            InitializeComponent();
            locations = GetLocationsFromFile(filePath);
            listBoxWeather.DataSource = locations;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            var geo = Geocoding.Search(listBoxWeather.Items[0].ToString(), geoApiKey);
            var lon = geo.features[0].center[0];
            var lat = geo.features[0].center[1];
            weather = new MyWeather(lat, lon, weatherApiKey);
            UpdateDisplay(weather);
            FillDaily(weather);
            FillHourly(weather);

        }

        private ObservableCollection<string> GetLocationsFromFile(string path)
        {
            ObservableCollection<string> locs;
            if (File.Exists(path))
            {
                locs = new ObservableCollection<string>(File.ReadAllLines(path));
            }
            else
            {
                using (StreamWriter w = File.AppendText(path));
                locs = new ObservableCollection<string>(File.ReadAllLines(path));
            }
            if (locs.Count == 0)
            {
                locs.Add("London");
            }
            return locs;
        }

        private void SaveLocationsToFile(string path)
        {
            File.WriteAllLines(path, locations);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            if (checkLocation(searchText))
            {
                MessageBox.Show("Location already exists");
            }
            else
            {
                locations.Add(searchText);
                listBoxWeather.DataSource = null;
                listBoxWeather.DataSource = locations;
            }
        }

        private bool checkLocation(string search)
        {
            foreach (string location in locations)
            {
                if (location.ToLower() == search.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        private void FillDaily(MyWeather weather)
        {
            tabControlWeather.TabPages[0].Controls.Clear();

            List<WeatherItem> items = new List<WeatherItem>();


            int count = 0;
            foreach (Daily day in weather.Daily)
            {
                string iconName = day.weather[0].icon;
                var icon = (Image)Properties.Resources.ResourceManager.GetObject("_"+iconName);

                items.Add(new WeatherItem(count.ToString(), icon, (int)day.temp.day, day.wind_deg, (int)day.wind_speed, day.dt
                    , day.weather[0].main,(int)day.rain,(int)day.feels_like.day,(int)day.dew_point,(int)day.pressure,(int)day.clouds,(int)day.temp.max,(int)day.temp.min,UnixTimeStampToDateTime(day.sunset).ToString("HH:mm"), UnixTimeStampToDateTime(day.sunrise).ToString("HH:mm")));
                count++;
            }
            items.Reverse();

            foreach (WeatherItem item in items)
            {
                WindControl w = new WindControl();

                if (item == items[items.Count - 1])
                {
                    w.Title = "Now";
                }
                else
                {
                    w.Title = item.Time.ToString();
                    DateTime today = UnixTimeStampToDateTime(item.Time);
                    w.Title = today.DayOfWeek.ToString().Substring(0, 3);
                }
                w.WeatherImage = item.WeatherImage;
                w.Temperature = item.Temperature;
                w.Degrees = item.WindDirection;
                w.WindSpeed = item.WindSpeed;
                w.Weather = item.Weather;
                w.FeelsLike = item.FeelsLike;
                w.DewPoint = item.DewPoint;
                w.Pressure = item.Pressure;
                w.Clouds = item.Clouds;
                w.MaxTemp = item.MaxTemp;
                w.MinTemp = item.MinTemp;
                w.Sunrise = item.Sunrise;
                w.Sunset = item.Sunset;
                w.Dock = DockStyle.Left;
                w.Padding = new Padding(0, 10, 0, 0);
                Panel spacer = new Panel();
                spacer.Width = 5;
                spacer.Height = w.Height;
                spacer.Dock = DockStyle.Left;
                tabControlWeather.TabPages[0].Controls.Add(spacer);
                tabControlWeather.TabPages[0].Controls.Add(w);

            }
        }

        private void FillHourly(MyWeather weather)
        {
            tabControlWeather.TabPages[1].Controls.Clear();

            List<WeatherItem> items = new List<WeatherItem>();


            int count = 0;
            foreach (Hourly hour in weather.Hourly)
            {
                string iconName = hour.weather[0].icon;
                var icon = (Image)Properties.Resources.ResourceManager.GetObject("_"+iconName);

                items.Add(new WeatherItem(count.ToString(), icon, (int)hour.temp, hour.wind_deg, (int)hour.wind_speed, hour.dt, hour.weather[0].main,(int)hour.feels_like,(int)hour.dew_point,hour.pressure,hour.clouds));
                count++;
            }
            items.Reverse();

            foreach (WeatherItem item in items)
            {
                WindControl w = new WindControl();

                if (item == items[items.Count - 1])
                {
                    w.Title = "Now";
                }
                else
                {
                    w.Title = item.Time.ToString();
                    DateTime today = UnixTimeStampToDateTime(item.Time);
                    w.Title = today.Hour + ":00";
                }
                w.WeatherImage = item.WeatherImage;
                w.Temperature = item.Temperature;
                w.Degrees = item.WindDirection;
                w.WindSpeed = item.WindSpeed;
                w.Weather = item.Weather;
                w.FeelsLike = item.FeelsLike;
                w.DewPoint = item.DewPoint;
                w.Pressure = item.Pressure;
                w.Clouds = item.Clouds;
                w.Dock = DockStyle.Left;
                w.Padding = new Padding(0, 10, 0, 0);
                Panel spacer = new Panel();
                spacer.Width = 5;
                spacer.Height = w.Height;
                spacer.Dock = DockStyle.Left;
                tabControlWeather.TabPages[1].Controls.Add(spacer);
                tabControlWeather.TabPages[1].Controls.Add(w);

            }
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        private void UpdateDisplay(MyWeather weather)
        {
            lblCurrTemp.Text = weather.Current.temp.ToString();
            lblDewPoint.Text = weather.Current.dew_point.ToString();
            lblFeelsLike.Text = weather.Current.feels_like.ToString();
            lblHumidity.Text = weather.Current.humidity.ToString();
            lblPressure.Text = weather.Current.pressure.ToString();
            lblSunrise.Text = weather.Current.sunrise.ToString();
            lblSunset.Text = weather.Current.sunset.ToString();
            lblTime.Text = weather.Current.dt.ToString();
            lblWindDir.Text = weather.Current.wind_deg.ToString();
            lblWindGust.Text = weather.Current.wind_gust.ToString();
            lblWindSpeed.Text = weather.Current.wind_speed.ToString();
            lblWeather.Text = weather.Current.weather[0].main.ToString();
            string img = weather.Current.weather[0].icon;
            pnlWeatherImage.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("_"+img);
        }

        private void listBoxWeather_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0 && listBoxWeather.SelectedItem != null)
            {
                var geo = Geocoding.Search(listBoxWeather.SelectedItem.ToString(), geoApiKey);
                var lon = geo.features[0].center[0];
                var lat = geo.features[0].center[1];
                weather = new MyWeather(lat, lon, weatherApiKey);

                tabControlWeather.SelectedTab.Hide();
                UpdateDisplay(weather);
                FillDaily(weather);
                FillHourly(weather);
                tabControlWeather.SelectedTab.Show();
            }
        }
    }
}
