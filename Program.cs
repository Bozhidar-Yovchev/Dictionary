using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContientCountryCapital
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number of countries:");
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, Dictionary<string, List<string>>>();

            Console.WriteLine("Enter Continent,Country and Capital");
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                var continent = tokens[0];
                var country = tokens[1];
                var capital = tokens[2];

                if (!dict.ContainsKey(continent))
                {
                    dict[continent] = new Dictionary<string, List<string>>();
                }

                if (!dict[continent].ContainsKey(country))
                {
                    dict[continent][country] = new List<string>();
                }

                dict[continent][country].Add(capital);
            }

            foreach (var continentCountries in dict)
            {
                var continentName = continentCountries.Key;
                Console.WriteLine($"{continentName}:");
                foreach (var countryCities in continentCountries.Value)
                {
                    var countryName = countryCities.Key;
                    var capitalNames = countryCities.Value;
                    Console.WriteLine($"{countryName} -> {string.Join(", ", capitalNames)}");
                }
            }

        }
    }
}
