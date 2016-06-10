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
        Random random = new Random();
        // PRIVATE INSTANCE VARIABLES=====================================================
        private string[] _superPowers;
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
        public void _generateRandomPowers()
        {
            string[] superPowers = new string[] { "Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "Weather Control"};
            for (int n = 0; n < 2; n++)
            {
                int rnd = random.Next(0, 6);
                string s = superPowers[rnd];
                
                Console.WriteLine("-> {0}", s);
            }
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
