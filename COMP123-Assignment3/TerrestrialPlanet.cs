using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

        /*
         * Author: Christopher Ritchil
         * Student # : 300702644
         * Date Created: July 6th 2016
         * Date modified: July 11th 2016
         * Description: This is the main mathod for driver class
         * Version: 0.1.0 - Final version 
         */

namespace COMP123_Assignment3
{
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        //PRIVATE INSTANCE VARIABLES / FIELDS ++++++++++++++++++++++++++++++++++++++++
        private bool _oxygen;

        //CONSTRUCTOR ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This constructor Method takes all parameters of the Planet base class and oxygen
        * </summary>
        * 
        * @constructor GiantPlanet
        * @param {string} name
        * @param {double} diameter
        * @param {double} mass
        * @param {string} oxygen
        */
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            :base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }
        // PUBLIC METHOD ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method returns true if the Habitable property has oxygen 
         * </summary>
         * 
         * @method Habitable
         * @returns {bool}
         */ 
        public bool Habitable()
        {
            if (_oxygen == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /**
         * <summary>
         * This method returns true if the MoonCount property is creater than zero
         * </summary>
         * 
         * @method HasMoons
         * @returns {bool}
         */
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}