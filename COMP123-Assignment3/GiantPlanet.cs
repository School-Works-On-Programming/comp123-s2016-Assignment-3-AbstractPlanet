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
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private string _type;

        // CONSTRUCTOR +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This constructor Method takes all parameters of the Planet and set the related instance variable
        * </summary>
        */
        public GiantPlanet(string name, double diameter, double mass, string type) 
            :base(name, diameter, mass)
        {
            this._type = type;
        }

        // PUBLIC METHOD ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
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
         /**
          * <summary>
          * This method returns true if the HasRings property is creater than zero
          * </summary>
          * 
          * @method HasRings
          * @returns {bool}
          */
        public bool HasRings()
        {
            if (RingCount < 0)
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