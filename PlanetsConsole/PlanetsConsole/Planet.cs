using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetsConsole
{
    public class Planet
    {
        public string? Name { get; set; }
        public double Weight { get; set; }
        public double YearLength { get; set; }
        public int DistanceFromSun { get; set; }
        public int NumberOfMoons { get; set; }
        public bool IsPlanet { get; set; }

        public string ToJSON()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public string HTML
        {
            get
            {
                StringBuilder html = new();

                html.Append($"<html><head><title>The planet of {Name}</title><head><body>");
                html.Append($"{Name} is a planet: {IsPlanet}");
                html.Append("</body></html");

                return html.ToString();
            }
        }
    }
}
