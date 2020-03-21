using System;
using System.Collections.Generic;

namespace PlanetsandSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            //1. `Add()` Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");


            //2.Create another `List` that contains that last two planet of our solar system.
            List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };

            //3.Combine the two lists by using `AddRange()`.
            planetList.AddRange(lastTwoPlanets);

            //4.Use `Insert()` to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            //5.Use `Add()` again to add Pluto to the end of the list.
            planetList.Add("Pluto");

            //6.Now that all the planets are in the list, slice the list using `GetRange()` in order to extract the rocky planets into a new list called `rockyPlanets`.
            planetList.GetRange(0, 3);

            //7.Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the `Remove()` method to eliminate it from the end of `planetList`.
            planetList.Remove("Pluto");

            //1.Create a dictionary that will hold the name of a spacecraft
            //that we have launched, and a list of names of the planets that it has
            //visited. Remember that `List` is a Type just like native types(such as `string`, `int`, & `bool`) and your custom types(such as `Movie`, `Dog`, and `Food`).
            //These types can be passed to anything, like a dictionary.

            var spacecraft = new Dictionary<string, string>();

            spacecraft.Add("Galileo", "Venus, 951 Gaspra, 243 Ida, Jupiter");
            spacecraft.Add("Voyager 1", "Earth, Jupiter, Saturn");
            spacecraft.Add("Voyager 2", "Earth, Jupiter, Saturn, Uranus, Neptune");
            spacecraft.Add("New Horizons", "132524 APL, Jupiter, Pluto, Kupier Belt");
            spacecraft.Add("Cassini", "Venus, 2685 Masursky, Jupiter, Saturn, Titan");
            //you cannot add two entries with the same key. it will throw an exception stating that the entry already exists

            //2.Iterate over your list of planets from above, and inside that loop,
            //iterate over the dictionary.Write to the console, for each planet,
            //which satellites have visited which planet.

            foreach (var (craft, planets) in spacecraft)
            {
                Console.WriteLine($"The {craft} satellite has flown to: {planets}.");
            }
        }   

    }
}
