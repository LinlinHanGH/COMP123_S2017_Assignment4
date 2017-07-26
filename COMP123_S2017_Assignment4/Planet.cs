using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Linlin Han
 * Date: July 26, 2017
 * Description: This is Abstract Planet class
 * Version: 0.2 - Added fields properties constructor and methods to Planet class
 */

namespace COMP123_S2017_Assignment4
{
    /// <summary>
    /// This is the Abstract Planet class
    /// </summary>
    public abstract class Planet
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        // PUBLIC PROPERTIES
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }

        public double Mass
        {
            get
            {
                return this._mass;
            }
        }

        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
        }

        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }

        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

        // CONSTRUCTORS
        /// <summary>
        /// This is the main constructor for Planet class.
        /// It takes 3 parameters - name(string) - diameter(double) - mass(double)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }
        // PRIVATE METHODS

        // PUBLIC METHODS
        /// <summary>
        /// The ToString method overrides the built-in Object.ToString method.
        /// It outputs a string that displays the name diameter and mass of planet.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString="";
            outputString += "-----------------------------------------------------------\n";
            outputString += "Name: " + this.Name + "\n";
            outputString += "Diameter: " + this.Diameter;
            outputString += "Mass: " + this.Mass;
            outputString += "-----------------------------------------------------------\n";
            //Console.WriteLine("Name: {0}"+"\n"+"Diameter: {1}" + "\n"+"Mass: {2}",
            //    this.Name,this.Diameter,this.Mass);
            return outputString;
        }
    }
}
