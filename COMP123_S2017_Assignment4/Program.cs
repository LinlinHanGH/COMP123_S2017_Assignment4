using System;

/*
 * Name: Linlin Han
 * Number: 300883493
 * Date: July 28, 2017
 * Description: Assignment4 - Abstract Planets
 * Version: 0.3 - Implement WaitForAnyKey method in Program class
 */

namespace COMP123_S2017_Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 142800, 18980, "Gas");
            Console.WriteLine(giantPlanet.ToString());
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 12742, 3.3, true);
            Console.WriteLine(terrestrialPlanet.ToString());
            WaitForAnyKey();
        }

        static void WaitForAnyKey()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
