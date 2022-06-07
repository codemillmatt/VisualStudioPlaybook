using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetsConsole
{
    public class SolarSystem
    {
        public List<Planet> Planets { get; }

        public SolarSystem()
        {
            Planets = new List<Planet>()
            {
                new Planet() { Name = "Mercury", IsPlanet = true, YearLength = 88, DistanceFromSun = 43366000, Weight = 0.4 },
                new Planet() { Name = "Venus", IsPlanet = true, YearLength = 102 },
                new Planet() { Name = "Earth", IsPlanet = true, YearLength = 365 },
                new Planet() { Name = "Mars", IsPlanet = true, YearLength = 1022 },
                new Planet() { Name = "Jupiter", IsPlanet = true, YearLength = 6423 },
                new Planet() { Name = "Saturn", IsPlanet = true, YearLength = 3321 },
                new Planet() { Name = "Uranus", IsPlanet = true, YearLength = 7781 },
                new Planet() { Name = "Neptune", IsPlanet = true, YearLength = 6612 },
                new Planet() { Name = "Pluto", IsPlanet = false, YearLength = 102881 }
            };
        }

        public void AddDwarfPlanet(string dwarfPlanetName)
        {
            if (string.IsNullOrEmpty(dwarfPlanetName))
                throw new ArgumentNullException(nameof(dwarfPlanetName));

            Planets.Add(new Planet { Name = dwarfPlanetName, IsPlanet = false });
        }
    }
}
