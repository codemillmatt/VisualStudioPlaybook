﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    public class SolarSystem
    {
        public List<Planet> Planets { get; }

        public SolarSystem()
        {
            Planets = new List<Planet>()
            {
                new Planet() { Name = "Mercury", IsPlanet = true },
                new Planet() { Name = "Venus", IsPlanet = true },
                new Planet() { Name = "Earth", IsPlanet = true },
                new Planet() { Name = "Mars", IsPlanet = true },
                new Planet() { Name = "Jupiter", IsPlanet = true },
                new Planet() { Name = "Saturn", IsPlanet = true },
                new Planet() { Name = "Uranus", IsPlanet = true },
                new Planet() { Name = "Neptune", IsPlanet = true },
                new Planet() { Name = "Pluto", IsPlanet = false }
            };
        }

        public void AddDwarfPlanet(string name)
        {
            Planets.Add(new Planet { Name = name, IsPlanet = false });
        }
    }
}
