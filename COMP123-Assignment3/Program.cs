using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        /*
         * Assignment #4
         * Author: Christopher Ritchil
         * Student # : 300702644
         * Date Created: July 6th 2016
         * Date modified: July 11th 2016
         * Description: This program demonstrates Abstract planet and shows Giant & Terrestrial planet
         * Version: 0.1.0 - Final version 
         */

namespace COMP123_Assignment3
{
    /**
    * This is the "driver" class for my Program
    * 
    * @class Program
    **/
    class Program
    {
        /**
        * this is the main method for the driver class 
        * 
        * @method Main
        * @param {sting[]} args
        * @returns {void}
        */

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+         Giant Planet              +");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.ResetColor();
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 1654879513, 9587411541, "Gas");
            Console.WriteLine(giantPlanet.ToString());
            Console.WriteLine("-------------------------------------");
            

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+        Terrestrial Planet         +");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.ResetColor();
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 654654, 981541, true);
            Console.WriteLine(terrestrialPlanet.ToString());
            Console.WriteLine("-------------------------------------");
            waitForAnyKey();
        }

         /**
         * <summary>
         * This method wait for a console key press from the user 
         * </summary>
         * 
         * @method WaitForAnyKey
         * @returns {void}
         */
        public static void waitForAnyKey()
        {
            Console.WriteLine("Please enter any key to continue.");
            Console.ReadKey();
        }
    }
}
