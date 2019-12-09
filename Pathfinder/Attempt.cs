using System;
using System.Collections.Generic;
using System.Text;

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
            //defualt will create a 1d20 with no bonus
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
