using System;
using Newtonsoft.Json.Linq;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();

            var key = "9d3aa6d3065b393c013faa83b6af2172";

            var city = "Birmingham";

            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={key}&units=imperial";

            var response = client.GetStringAsync(weatherURL).Result;

            JObject formattedResponse = JObject.Parse(response);
            var temp = formattedResponse["main"]["temp"];
            //Console.WriteLine(formattedResponse);
            Console.WriteLine(temp);
        }
    }
}