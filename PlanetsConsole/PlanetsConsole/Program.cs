// See https://aka.ms/new-console-template for more information
using PlanetsConsole;

Console.WriteLine("Hello, World - I mean solar system!");

SolarSystem solarSystem = new();

foreach (var planet in solarSystem.Planets)
{
    Console.WriteLine($"Welcome to {planet.Name}");

    RocketShip ship = new RocketShip();
    ship.TravelTo(planet, new Astronaut());
}