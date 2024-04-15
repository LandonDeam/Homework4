using System;
using System.Collections.Generic;

namespace Cities
{
    public class CityStates
    {
        public static void Solution(string File = "CityStates.txt")
        {
            try
            {
                List<string> cities = new List<string>();
                string line;
                StreamReader sr = new StreamReader("cities.txt");
                while ((line = sr.ReadLine()) != null)
                {
                    cities.Add(line);
                }
                sr.Close();
            }
            catch (Exception) {}
        }
    }
}