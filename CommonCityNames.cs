using System.Collections.Generic;
using System;
using System.IO;

namespace Cities
{
    public class CommonCityNames
    {
        private static Dictionary<string, List<string>> cities = new Dictionary<string, List<string>>();

        public static void add(string city, string state) {
            if (cities.ContainsKey(city) && !cities[city].Contains(state))
            {
                cities[city].Add(state);
            } 
            else if (!cities.ContainsKey(city))
            {
                cities[city] = new List<string>();
                cities[city].Add(state);
            }
        }

        public static List<string> getCommon(string state1, string state2)
        {
            List<string> list = new List<string>();
            foreach (string city in cities.Keys)
            {
                if (cities[city] != null &&
                    cities[city].Contains(state1) &&
                    cities[city].Contains(state2)
                    )
                {
                    list.Add(city);
                }
            }
            return list;
        }

        public static void Solution(string File = "CommonCityNames.txt")
        {
            foreach (var city in ReadZipCodes.cities)
            {
                add(city.city, city.State);
            }

            try
            {
                StreamReader sr = new StreamReader("states.txt");
                string state1 = sr.ReadLine();
                string state2 = sr.ReadLine();
                sr.Close();
                StreamWriter sw = new StreamWriter(File);
                List<string> list = getCommon(state1, state2);
                list.Sort();
                foreach (var city in list)
                {
                    sw.WriteLine(city);
                }
                sw.Close();
            }
            catch (Exception) {}
        }
    }
}