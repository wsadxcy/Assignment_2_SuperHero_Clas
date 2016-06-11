using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Author : Chenyuan Xie
 * Date : June 2th, 2016
 * Date Modified: Jun 10th, 2016
 * Description : Assignment 2
 * Version : 1.0 - 
 *                  Updated Documentary;
                    Finished;
 */
namespace Assignment_2_Superhero_Class
{
    /**
     * This class is the driver class for the program
     * 
     * @class program
     */
    public class Program
    {
        /**
         * the main method for my driver class
         * 
         * @method Main
         * @param {sting[]} args
         */
        static void Main(string[] args)
        {
            
            Hero Slasher = new Hero();
            Slasher.Name = "Slasher";
            Slasher.Show();
            Slasher.Fight();

            Console.WriteLine();

            Hero Cybermancer = new Hero("Cybermancer");
            Cybermancer.Show();
            Cybermancer.Fight();

            Console.WriteLine();

            Hero Nihil = new Hero("Nihil");
            Nihil.Show();
            Nihil.Fight();

            Console.WriteLine();

            Hero Elementalist = new Hero();
            Elementalist.Name = "Elementalist";
            Elementalist.Show();
            Elementalist.Fight();

            SuperHero Superman = new SuperHero("Superman");
            Superman.Show();
            Superman.ShowPowers();
            Superman.Fight();

            SuperHero Batman = new SuperHero("Batman");
            Batman.Show();
            Batman.ShowPowers();
            Batman.Fight();
            
            SuperHero Punisher = new SuperHero("Punisher");
            Punisher.Show();
            Punisher.ShowPowers();
            Punisher.Fight();
            
        }
    }
}
