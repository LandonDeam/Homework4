using System.Collections.Generic;
using System;

namespace Cities
{
    public class CommonCity
    {
        private static Dictionary<string, List<string>> cities = new Dictionary<string, List<string>>();

        public static void add(string city, string state) {
            if (cities[city] is not null && !cities[city].Contains(state)) 
            {
                cities[city].Add(state);
            }
        }

        public static List<string> getCommon(string state1, string state2)
        {
            List<string> list = new List<string>();
            foreach (string city in cities.Keys)
            {
                if (cities[city] is not null &&
                    cities[city].Contains(state1) &&
                    cities[city].Contains(state2)
                    )
                {
                    list.Add(city);
                }
            }
            return list;
        }
    }
}