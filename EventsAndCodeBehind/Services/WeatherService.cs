using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndCodeBehind.Services
{
    internal static class WeatherService
    {
        public static string Location { get; set; } = "Unknown";

        public static double Humidity { get; private set; } = 0;

        public static void Refresh()
        {
            var random = new Random();
            Humidity = random.Next(30,95);
            System.Diagnostics.Debug.WriteLine($"Weather refreshed for {Location}: {Humidity}%");
        }
    }
}
