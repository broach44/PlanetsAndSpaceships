using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            planetList.AddRange(lastTwoPlanets);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            var rockyPlanets = planetList.GetRange(0, 4);
            planetList.Remove("Pluto");
            Console.WriteLine($"{String.Join(", ", planetList)}");
            Console.WriteLine($"These are the rocky planets: {string.Join(", ", rockyPlanets)}");
            Console.ReadLine();

        }
    }
}
