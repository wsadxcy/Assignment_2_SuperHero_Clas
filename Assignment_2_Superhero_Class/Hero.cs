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
        private string[] _enemys;

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

        /**
         * This is the public property for private enemy field
         * 
         * @property {string[]} Enemy
         */
        public string[] Enemys
        {
            get
            {
                return this._enemys;
            }

            set
            {
                this._enemys = value;
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
            _generateRandomEnemy();
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
            _generateRandomEnemy();
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

        /**
         * <summary>
         * This method randomly generate and  a string of Enemy, and remove enemy until 1 left
         * </summary>
         * 
         * @method _generateRandomEnemy
         * @returns {void}
         */
        private void _generateRandomEnemy()
        {
            string[] enemy = new string[] { "Goblin", "Orc", "Spider", "Skeleton", "Zombie", "Bat" };
            _enemys = enemy;

            int enemyCount = enemy.Length;

            for (int currentenemy = 0; currentenemy < enemyCount; currentenemy++)
            {
                string tempEnemy = enemy[currentenemy]; // copy current enemy to temp location
                int randomenemy = random.Next(0, enemyCount); // get a random enemy index
                enemy[currentenemy] = enemy[randomenemy]; // copy value from randomenemy to currenenemy
                enemy[randomenemy] = tempEnemy; // copy current enemy to random enemy
            }

            if (_enemys.Length > 1)
            {
                string[] enemygenerate = _enemys.Skip(1).ToArray(); // remove the 0th enemy from enemy Pool 
            }
        }

        //PUBLIC METHODS====================================================================

        /**
        * <summary>
        * This method outputs the _hitDamage, _hitAttempt and attacking enemy value to the console.
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
                Console.WriteLine("A hostile creature has appeared.\nOur hero attacked the creature.");
                Console.WriteLine("Hero " + this.Name + " Deals " + _hitDamage() + " Damage to " + "{0}" + "\n", _enemys);
            }
            else
            {
                Console.WriteLine("A hostile creature has appeared.\nOur hero attacked the creature.");
                Console.WriteLine("Hero " + this.Name + " Missed");
                Console.WriteLine("Target enemy is a/an {0}" + "\n", _enemys);
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
            string bar = new string('=',65);
            string strengthbar = new String('█', _strength/4);
            string speedbar = new String('█', _speed/4);
            string healthbar = new String('█', _health/4);
            Console.WriteLine(bar + "\n*Hero : " + this.Name);
            Console.WriteLine("*Strength : "  + "" + strengthbar+ " " + _strength);
            Console.WriteLine("*Speed : " +  "   " + speedbar + " " + _speed);
            Console.WriteLine("*Health : "  + "  " + healthbar + " " + _health + "\n" + bar);

        }
    }
}
