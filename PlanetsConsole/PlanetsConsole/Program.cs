// See https://aka.ms/new-console-template for more information
using PlanetsConsole;

Console.WriteLine("Hello, World - I mean solar system!");

SolarSystem solarSystem = new();

foreach (var planet in solarSystem.Planets)
{
    Console.WriteLine($"Welcome to {planet.Name}");
}

try
{
    solarSystem.AddDwarfPlanet(null);
}
catch (ArgumentNullException)
{
    Console.WriteLine("I told you not to make it null!");
}