using System;
using System.Collections.Generic;
using System.Text;

namespace Pathfinder
{
    /* TODO
     * Look at get set
     * double check inheritenace for finalbonus, will rename for now
     */
    public class ACBonus : Bonus
    {
        private readonly int ACBase = 10;
        public ACBonus(Levels pro, int lev, int att, int cir = 0, int ite = 0, int stat = 0, int unty = 0) : 
            base(pro, lev, att, cir, ite, stat, unty) {

        }

        public void MaxArmorBonus(int maxarmor)
        {
            // need to be reran after reset
            if (this.attribute > maxarmor)
            {
                this.attribute = maxarmor;
            }
        }

        public int FinalACBonus()
        {
            if (forced != 0)
            {
                return forced;
            }
            return this.FinalBonus() + this.ACBase;
        }
    }
}
