using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    public class RocketShip
    {
        public void TravelTo(Planet planet, Astronaut astronaut)
        {
            astronaut.Explore(planet);
        }
    }
}
