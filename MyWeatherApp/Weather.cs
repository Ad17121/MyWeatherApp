using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;


public class MyWeather
{
    public double Lat { get; set; }
    public double Lon { get; set; }
    private string ApiKey { get; set; }

    public Current Current { get; set; }

    public List<Daily> Daily { get; set; }

    public List<Hourly> Hourly { get; set; }

    public MyWeather(double lat, double lon, string apiKey)
    {
        this.Lat = lat;
        this.Lon = lon;
        this.ApiKey = apiKey;
        this.Update();
    }

    private static string GetWeatherJSON(double lat, double lon, string apiKey)
    {
        string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&appid={2}", lat, lon, apiKey);
        WebRequest request = WebRequest.Create(url);
        WebResponse response = request.GetResponse();
        var responseStream = response.GetResponseStream();
        using (StreamReader sr = new StreamReader(responseStream))
        {
            return sr.ReadToEnd();
        }

    }

    private static OpenWeather DeserializeWeatherJSON(string json)
    {
        OpenWeather weather = JsonSerializer.Deserialize<OpenWeather>(json);
        return weather;
    }

    private static double KelvinToCelsius(double temp)
    {
        return Math.Round(temp - 273.15, 1);

    }

    private static int MsToMph(double speed)
    {
        return (int)Math.Round(speed * 2.23694);
    }

    public void Update()
    {
        var json = GetWeatherJSON(this.Lat, this.Lon, this.ApiKey);
        var weather = DeserializeWeatherJSON(json);

        this.Current = weather.current;
        this.Current.temp = KelvinToCelsius(this.Current.temp);
        this.Current.feels_like = KelvinToCelsius(this.Current.feels_like);
        this.Current.dew_point = KelvinToCelsius(this.Current.dew_point);
        this.Current.wind_speed = MsToMph(this.Current.wind_speed);
        this.Current.wind_gust = MsToMph(this.Current.wind_gust);

        this.Daily = weather.daily;

        foreach (Daily d in this.Daily)
        {
            d.temp.day = KelvinToCelsius(d.temp.day);
            d.temp.min = KelvinToCelsius(d.temp.min);
            d.temp.max = KelvinToCelsius(d.temp.max);
            d.temp.night = KelvinToCelsius(d.temp.night);
            d.temp.eve = KelvinToCelsius(d.temp.eve);
            d.temp.morn = KelvinToCelsius(d.temp.morn);

            d.dew_point = KelvinToCelsius(d.dew_point);

            d.feels_like.day = KelvinToCelsius(d.feels_like.day);
            d.feels_like.night = KelvinToCelsius(d.feels_like.night);
            d.feels_like.eve = KelvinToCelsius(d.feels_like.eve);
            d.feels_like.morn = KelvinToCelsius(d.feels_like.morn);

            d.wind_speed = MsToMph(d.wind_speed);
        }

        this.Hourly = weather.hourly;

        foreach (Hourly h in this.Hourly)
        {
            h.temp = KelvinToCelsius(h.temp);
            h.feels_like = KelvinToCelsius(h.feels_like);
            h.wind_speed = MsToMph(h.wind_speed);
            h.dew_point = KelvinToCelsius(h.dew_point);
        }
    }
}

