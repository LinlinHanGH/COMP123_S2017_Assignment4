using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Linlin Han
 * Number: 300883493
 * Date: July 26, 2017
 * Description: This is TerrestrialPlanet class
 * Version: 0.1 - Created TerrestrialPlanet class
 */
namespace COMP123_S2017_Assignment4
{
    /// <summary>
    /// This is TerrestrialPlanet class
    /// </summary>
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private bool _oxygen;

        // PUBLIC PROPERTIES


        // CONSTRUCTORS
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }
        // PRIVATE METHODS

        // PUBLIC METHODS
       
        
    }
}
