using System;
using System.Collections.Generic;
using System.Text;
/* This will class will be used for all stats that dices are applied to
 * attacks, 
 * TODO
 * add logging
 * add printing
 * add increase proficency
 * add increase level
 * add increase stats
 */
namespace Pathfinder
{
    class Attempt
    {
        private Dice dice;
        private Bonus bonus;

        public int AttemptCheck()
        {
            return this.dice.Roll() + this.bonus.FinalBonus();
        }

        public Attempt()
        {
            //defualt will create a 1d20 with +1 bonus
            dice = new Dice();
            bonus = new Bonus();
        }

        public Attempt(Dice die, Bonus bon)
        {
            this.dice = die;
            this.bonus = bon;
        }
    }
}
