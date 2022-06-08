using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetsConsole
{
    public class Astronaut
    {
        public void Explore(Planet planet)
        {
            JetPackAround(planet.Name);
        }

        void JetPackAround(string? planetName)
        {
            Console.WriteLine($"I am flying around {planetName}!");
        }
    }
}