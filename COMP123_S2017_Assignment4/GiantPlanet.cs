using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Linlin Han
 * Number: 300883493
 * Date: July 26, 2017
 * Description: This is Abstract Planet class
 * Version: 0.1 - Created GiantPlanet class
 */

namespace COMP123_S2017_Assignment4
{
    /// <summary>
    /// This is GiantPlanet class.
    /// </summary>
    public class GiantPlanet : Planet,IHasMoons,IHasRings
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private string _type;

        // PUBLIC PROPERTIES


        // CONSTRUCTORS
        public GiantPlanet(string name, double diameter, double mass, string type)
            : base(name, diameter, mass)
        {
            this._type = type;
        }
        // PRIVATE METHODS

        // PUBLIC METHODS
        public bool HasMoons()
        {
            if ()
        }
    }
}
