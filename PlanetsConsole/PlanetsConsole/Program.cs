// See https://aka.ms/new-console-template for more information
using PlanetsConsole;

Console.WriteLine("Hello, World - I mean solar system!");

SolarSystem solarSystem = new();

var mercuryInfo = solarSystem.Planets[0].Name;
mercuryInfo += $" has a year length of {solarSystem.Planets[0].YearLength} and weighs {solarSystem.Planets[0].Weight} with a json of {solarSystem.Planets[0].ToJSON()}";


var mercuryYearLength = solarSystem.Planets[0].YearLength;

var venusName = solarSystem.Planets[1].Name;
var venusYearLength = solarSystem.Planets[1].YearLength;

var theEarth = solarSystem.Planets[2];

Console.WriteLine(theEarth.Name);