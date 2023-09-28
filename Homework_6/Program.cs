using System;
using System.Numerics;

namespace Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programm 1
            var planet1 = new { Name = "Венера", Number = 2, Length = 38025, PreviousPlanet = null as Planet };
            var planet2 = new { Name = "Земля", Number = 3, Length = 40075, PreviousPlanet =  planet1 } ;
            var planet3 = new { Name = "Марс", Number = 4, Length = 21344, PreviousPlanet = planet2 };
            var planet4 = new { Name = "Венера", Number = 2, Length = 38025, PreviousPlanet = null as Planet };
           
            Console.WriteLine($"Имя планеты = {planet1.Name}, Порядковый номер от Солнца = {planet1.Number}, Длина экватора = {planet1.Length}, Предыдущая планета = {planet1.PreviousPlanet}");
            Console.WriteLine("Это планета Венера? " +  planet1.Equals(planet1));
            Console.WriteLine($"Имя планеты = {planet2.Name}, Порядковый номер от Солнца = {planet2.Number}, Длина экватора = {planet2.Length}, Предыдущая планета = {planet2.PreviousPlanet.Name}");
            Console.WriteLine("Это планета Венера? " + planet1.Equals(planet2));
            Console.WriteLine($"Имя планеты = {planet3.Name}, Порядковый номер от Солнца = {planet3.Number}, Длина экватора = {planet3.Length}, Предыдущая планета = {planet3.PreviousPlanet.Name}");
            Console.WriteLine("Это планета Венера? " + planet1.Equals(planet3));
            Console.WriteLine($"Имя планеты = {planet4.Name}, Порядковый номер от Солнца = {planet4.Number}, Длина экватора = {planet4.Length}, Предыдущая планета = {planet1.PreviousPlanet}");
            Console.WriteLine("Это планета Венера? " + planet1.Equals(planet4));

            Console.WriteLine("\n");
            //Programm 2
            PlanetsCatalog planetsCatalog = new PlanetsCatalog();
            
            (int, int, string) result1 = planetsCatalog.GetPlanet("Земля");
            Console.WriteLine(result1);
            (int, int, string) result2 = planetsCatalog.GetPlanet("Лимония");
            Console.WriteLine(result2);           
            (int, int, string) result3 = planetsCatalog.GetPlanet("Марс");
            Console.WriteLine(result3);

            Console.WriteLine("\n");
            //Program 3
            PlanetsCatalogCustom planetsCatalogCustom = new PlanetsCatalogCustom();
            (int, int, string) result4 = planetsCatalogCustom.GetPlanet("Земля", x => Validator(x));
            Console.WriteLine(result4);
            (int, int, string) result5 = planetsCatalogCustom.GetPlanet("Лимония", x => Validator(x));
            Console.WriteLine(result5);
            (int, int, string) result6 = planetsCatalogCustom.GetPlanet("Марс", x => Validator(x));
            Console.WriteLine(result6);
            (int, int, string) result7 = planetsCatalogCustom.GetPlanet("Лимония", x => Validator2(x));
            Console.WriteLine(result7);
        }


        private static string Validator2(string planet)
        {
            if (planet == "Лимония")
            {
                return "Это запретная планета!";
            }
            return null;
        }

        private static int count;
        private static string Validator(string planet)
        {
            count++;
            if (count == 3)
            {
                count = 0;
                return "Вы спрашиваете слишком часто!";

            }
            return null;
        }

    }
}