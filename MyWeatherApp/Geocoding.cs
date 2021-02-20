using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Net;
using System.Collections.Generic;

public class Geocoding
{

    private static string SearchString { get; set; }
    private static string ApiKey { get; set; }

    public static GeocodingApi Search(string search, string apiKey)
    {
        SearchString = search;
        ApiKey = apiKey;
        var json = GetGeoJSON(SearchString, ApiKey);
        var geo = DeserializeGeoJSON(json);
        return geo;
    }

    private static string GetGeoJSON(string search, string apiKey)
    {
        try
        {
            string url = string.Format("https://api.mapbox.com/geocoding/v5/mapbox.places/{0}.json?access_token={1}", search, apiKey);
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            var responseStream = response.GetResponseStream();
            using (StreamReader sr = new StreamReader(responseStream))
            {
                return sr.ReadToEnd();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }

    }

    private static GeocodingApi DeserializeGeoJSON(string json)
    {
        var weather = JsonSerializer.Deserialize<GeocodingApi>(json);
        return weather;
    }
}
