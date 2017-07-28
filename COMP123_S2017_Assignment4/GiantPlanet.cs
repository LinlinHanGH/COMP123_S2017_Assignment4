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
 * Version: 0.2 - Added HasMoons HasRings method in GiantPlanet class
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
        /// <summary>
        /// This method will return true if the MoonCount property is greater than zero
        /// </summary>
        /// <returns></returns>
        public bool HasMoons()
        {
            if (MoonCount > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// This method will return true if the RingCount property is greater than zero
        /// </summary>
        /// <returns></returns>
        public bool HasRings()
        {
            if (RingCount > 0)
                return true;
            else
                return false;
        }

    }
}
