/*
 * Name: Linlin Han
 * Number: 300883493
 * Date: July 28, 2017
 * Description: This is TerrestrialPlanet class
 * Version: 0.1 - Added HasMoons Habitable method in TerrestrialPlanet class
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
        /// This method will return true if the oxygen instance variable is set to true
        /// </summary>
        /// <returns></returns>
        public bool Habitable()
        {
            if (this._oxygen == true)
                return true;
            else
                return false;
        }


    }
}
