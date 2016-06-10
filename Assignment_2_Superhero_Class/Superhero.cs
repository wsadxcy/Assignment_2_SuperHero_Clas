using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Superhero_Class
{
    /**
     * <summary>
     * This is the SuperHero class. It is derived from the Hero class
     * </summary>
     * 
     * @class SuperHero
     * @extends Hero
     */
    class SuperHero : Hero
    {
        //RANDOM NUMBER GENERATOR=========================================================
        Random random = new Random(Guid.NewGuid().GetHashCode());
        // PRIVATE INSTANCE VARIABLES=====================================================
        private string[] _superPowers;
        // PUBLIC PROPERTIES==============================================================
        /**
         * This is the public property for private _superPowers field
         * 
         * @property {string[]} SuperPowers
         */
        public string[] SuperPowers
        {
            get
            {
                return this._superPowers;
            }

            set
            {
                this._superPowers = value;
            }
        }
        // PRIVATE METHODS===================================================================
        /**
         * <summary>
         * This method randomly generate and  a string of Superpower, and remove superpower until 3 left
         * </summary>
         * 
         * @method _generateRandomPowers
         * @returns {void}
         */
        private void _generateRandomPowers()
        {
            string[] superPowers = new string[] { "Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "Weather Control"};
            _superPowers = superPowers;

            int powerCount = superPowers.Length;

            for (int currentpower = 0; currentpower < powerCount; currentpower++)
            {
                string tempPower = superPowers[currentpower]; // copy current power to temp location
                int randompower = random.Next(0, powerCount); // get a random power index
                superPowers[currentpower] = superPowers[randompower]; // copy value from randompower to currentpower
                superPowers[randompower] = tempPower; // copy current power to random power
            }

            if (_superPowers.Length > 3)
            {
                string[] superPowergenerate = _superPowers.Skip(1).ToArray(); // remove the 0th Power from Super Power Pool
            }
        }
        // PUBLIC METHODS===================================================================
        public void ShowPowers()
        {
            Console.WriteLine();
            Console.WriteLine("-> {0} \n-> {1}\n-> {2}", _superPowers);
            Console.WriteLine();
        }
        // CONSTRUCTORS =====================================================================
        public SuperHero(string name) : base(name)
        {
            _generateRandomPowers();
        }
    }
}
