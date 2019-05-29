using System;
using System.Collections.Generic;

namespace planets_and_probes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

            Dictionary<string, string> mariner10 = new Dictionary<string, string>() {
               {"mariner10", "Mercury"}
           };

            Dictionary<string, string> mariner2 = new Dictionary<string, string>() {
               {"mariner2", "Venus"}
           };

            Dictionary<string, string> mariner4 = new Dictionary<string, string>() {
               {"mariner4", "Mars"}
           };

            Dictionary<string, string> newHorizons = new Dictionary<string, string>() {
               {"New Horizons", "Pluto"}
           };
            List<KeyValuePair<string, string>> probeDestinations = new List<KeyValuePair<string, string>>();

            probeDestinations.AddRange(mariner10);
            probeDestinations.AddRange(mariner2);
            probeDestinations.AddRange(mariner4);
            probeDestinations.AddRange(newHorizons);

            // foreach (KeyValuePair<string, string> dest in probeDestinations)
            // {
            //     Console.WriteLine($"{dest.Key} to {dest.Value}");
            // }

            // Iterate planets
            foreach (string planet in planetList)
            {
                // List to store probes that visited the planet
                List<string> matchingProbes = new List<string>();

                // Iterate probeDestinations
                foreach (KeyValuePair<string, string> dest in probeDestinations)
                {
                    /*
                        Does the current probe's destination
                        match the value of the `planet` variable?
                        If so, add it to the list.
                    */

                    if(planet == dest.Value){
                        matchingProbes.Add(dest.Key);
                    }
                }

                /*
                    Use String.Join(",", matchingProbes) as part of the
                    solution to get the output below. It's the C# way of
                    writing `array.join(",")` in JavaScript.
                */
                Console.WriteLine($"{planet}: {String.Join(", ", matchingProbes)}");
            }




        }
    }
}
