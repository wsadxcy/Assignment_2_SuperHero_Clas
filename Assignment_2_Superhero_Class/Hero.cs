using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Superhero_Class
{
    /**
    * This class define a Hero
    * 
    * @class Hero
    */
    public class Hero
    {
        //RANDOM NUMBER GENERATOR=========================================================
        Random random = new Random(Guid.NewGuid().GetHashCode());
        // PRIVATE INSTANCE VARIABLES=====================================================
        private string _name;
        private int _strength;
        private int _speed;
        private int _health;

        // PUBLIC PROPERTIES==============================================================
        /**
         * This is the public property for private _name field
         * 
         * @property {string} Name
         */
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        // CONSTRUCTORS =====================================================================

        /**
         * <summary>
         * This is the default empty constructor for the Hero class
         * </summary>
         * 
         * @constructor Hero
         */
        public Hero()
        {
            this.Name = "Unknown Name";
            _generateAbilities();

        }

        /**
         * <summary>
         * This is a consructor that takes name as a parameter and passes 
         * it to the _name private instance variable
         * </summary>
         * 
         * @constructor Hero
         * @param {string} name
         */
        public Hero(string name)
        {
            this.Name = name;
            _generateAbilities();
        }
        // PRIVATE METHODS===================================================================

        /**
         * <summary>
         * This Method generate hero's strength, speed and health between 1 and 100 using a random number generator.
         * </summary>
         * 
         * @Method _generateAbilities
         * @returns {void}
         */
        private void _generateAbilities()
        {
            _strength = random.Next(1, 100);
            _speed = random.Next(1, 100);
            _health = random.Next(1, 100);

        }

        /**
         * <summary>
         * This Method randomly determine if the Hero hits
         * </summary>
         * 
         * @Method _hitAttempt
         * @returns {bool}
         */
        private bool _hitAttempt()
        {
            bool hit = false;
            int HitAtp = random.Next(4);

            if (HitAtp == 0)
            {
                hit = true;
            }
            return hit;
        }

        /**
         * <summary>
         * This Method calculates the damage the Hero causes to the target on a hit.
         * FinDam = _strength * DamMult
         * FinDam is the final damage Hero will cause to the target.
         * DamMult is ramdomly generated between 1 and 6. 
         * </summary>
         */
        private int _hitDamage()
        {
            int DamMult = random.Next(1, 6);

            int FinDam = _strength * DamMult;
            return FinDam;
        }

        //PUBLIC METHODS====================================================================

        /**
        * <summary>
        * This method outputs the _hitDamage value to the console.
        * </summary>
        * 
        * @method Fight
        * @returns {void}
        */
        public void Fight()
        {
            bool hit = _hitAttempt();
            if
                (hit == true)
            {

                Console.WriteLine("\n" + this.Name + " Deals " + _hitDamage() + " Damage to target enemy.");
            }
            else
            {
                Console.WriteLine("\n" + this.Name + " Missed");
            }
        }

        /**
        * <summary>
        * This method outputs the _strength, _speed, _health value to the console.
        * </summary>
        * 
        * @method Show
        * @returns {void}
        */
        public void Show()
        {
            Console.WriteLine("*****************\nHero : " + this.Name + "     \n*Strength : " + _strength + "   \n*Speed : " + _speed + "   \nHealth : " + _health + "   \n*****************");
        }
    }
}
