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
            Console.WriteLine($"List of planets: {String.Join(", ", planetList)}");
            Console.WriteLine($"These are the rocky planets: {string.Join(", ", rockyPlanets)}");

            var mercuryProbes = new List<string> { "Mariner 10", "Messenger" };
            var venusProbes = new List<string> { "Mariner 2", "Venera 4", "Mariner 5", "Venera 5", "Venera 6", "Pioneer Venus Orbiter", "Venera 12", "Venera 11" };
            var marsProbes = new List<string> { "2001 Mars Odyssey", "Mars Express", "MSL Curiosity", "MAVEN" };
            var jupiterProbes = new List<string> { "Ulysses", "New Horizons", "Voyager 1", "Voyager 2" };
            var saturnProbes = new List<string> { "Voyager 1", "Voyager 2", "Pioneer 11",  };
            var uranusProbes = new List<string> { "Voyager 2" };
            var neptuneProbes = new List<string> { "Voyager 2" };

            var solarSystemProbes = new Dictionary<string, List<string>>();
            
            solarSystemProbes.Add("Mercury", mercuryProbes);
            solarSystemProbes.Add("Venus", venusProbes);
            solarSystemProbes.Add("Mars", marsProbes);
            solarSystemProbes.Add("Jupiter", jupiterProbes);
            solarSystemProbes.Add("Saturn", saturnProbes);
            solarSystemProbes.Add("Uranus", uranusProbes);
            solarSystemProbes.Add("Neptune", neptuneProbes);


            foreach (var planet in solarSystemProbes)
            {
                Console.WriteLine($"{planet.Key} has the following probes: {String.Join(", ", planet.Value)}");
                
            }

            Console.ReadLine();

        }
    }
}
