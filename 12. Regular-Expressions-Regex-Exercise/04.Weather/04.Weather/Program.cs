using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Weather
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string pattern = @"([A-Z]{2}(?=[0-9\.]+))([0-9]+\.[0-9]+(?=[a-zA-Z]))([a-zA-Z]+(?=\|))";

            var input = Console.ReadLine();

            var wheatherForecast = new Dictionary<string, List<dynamic>>();

            while (true)
            {
                if (input == "end")
                {
                    break;
                }

                var forecasts = Regex.Matches(input, pattern);

                foreach (Match forecast in forecasts)
                {
                    var city = forecast.Groups[1].Value;
                    double temp = double.Parse(forecast.Groups[2].Value);
                    var wheath = forecast.Groups[3].Value;

                    if (!wheatherForecast.ContainsKey(city))
                    {
                        wheatherForecast[city] = new List<dynamic>();
                        wheatherForecast[city].Add(temp);
                        wheatherForecast[city].Add(wheath);
                    }
                    else
                    {
                        wheatherForecast[city][0] = temp;
                        wheatherForecast[city][1] = wheath;
                    }
                }

                input = Console.ReadLine();
            }

            wheatherForecast = wheatherForecast.OrderBy(a => a.Value[0]).ToDictionary(k => k.Key, v => v.Value);

            foreach (var city in wheatherForecast)
            {
                Console.WriteLine($"{city.Key} => {city.Value[0]:f2} => {city.Value[1]}");
            }
        }
    }
}