using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework_6
{
    public class PlanetsCatalogCustom
    {
        private List<Planet> _planets = new List<Planet>();
        int count = 0;
        public PlanetsCatalogCustom()
            
        {
           
            Planet planet1 = new Planet { Name = "Венера", Number = 2, Length = 38025};
            Planet planet2 = new Planet { Name = "Земля", Number = 3, Length = 40075, PreviousPlanet = planet1 };
            Planet planet3 = new Planet { Name = "Марс", Number = 4, Length = 21344, PreviousPlanet = planet2 };
            _planets.Add(planet1);
            _planets.Add(planet2);
            _planets.Add(planet3);
        }


        public (int, int, string) GetPlanet(string name, Func<string?, string> validator)
        {
            string result = validator(name);
            
            if (result != null) 
            {
                return (0, 0, result);
            }

            foreach (Planet planet in _planets)
            {
                if (planet.Name == name)
                {
                    return (planet.Number, planet.Length, null);
                }
            }
            return (0, 0, "Не удалось найти планету!");
        }

       





    }
}
