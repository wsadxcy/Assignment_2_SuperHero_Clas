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
        // PRIVATE INSTANCE VARIABLES=====================================================
        private string[] _superPowers = new string[] { "Super	Speed", "Super	Strength", "Body	Armour", "Flight", "Fire	Generation", "Weather	Control" };
        // PUBLIC PROPERTIES==============================================================
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
        private void _generateRandomPowers()
        {

        }
        // PUBLIC METHODS===================================================================
        public void ShowPowers()
        {

        }
        // CONSTRUCTORS =====================================================================
        public SuperHero()
        {
            this.Name = "Unknown Name";
            _generateRandomPowers();

        }
    }
}
