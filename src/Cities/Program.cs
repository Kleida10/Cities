using System;
using System.Collections.Generic;
using Cities.Comparers;

namespace Cities
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<City> cities = CityDataImporter.LoadData();

            // TODO Swap out comparers as desired
            IComparer<City> comparerN = new NameComparer();
            IComparer<City> comparerS = new StateComparer();
            IComparer<City> comparerA = new AreaComparer();
            IComparer<City> comparerP = new PopulationComparer();


            //cities.Sort(comparerN);
            //cities.Sort(comparerS);
            cities.Sort(comparerA);
            //cities.Sort(comparerP);

            PrintCities(cities);

            Console.ReadLine();
        }

        private static void PrintCities(List<City> cities)
        {
            Console.WriteLine(City.GetTableHeader());

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

        }
    }
}
