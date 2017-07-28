using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Linlin Han
 * Number: 300883493
 * Date: July 28, 2017
 * Description: Assignment4 - Abstract Planets
 * Version: 0.2 - Created a new giantPlanet object and a new terristrial object in Program class
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
           

        }

        

    }
}
