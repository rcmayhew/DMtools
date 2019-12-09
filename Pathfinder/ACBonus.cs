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
        public ACBonus(Levels pro, int lev, int cir = 0, int ite = 0, int stat = 0, int unty = 0) {
            this.level = lev;
            this.proficiency = new Proficiency(pro, lev);
            this.circumstantial = cir;
            this.item = ite;
            this.status = stat;
            this.untyped = unty;

        }

        public int FinalACBonus()
        {
            if (forced != 0)
            {
                return forced;
            }
            return this.proficiency.ProficiencyBonus() + this.level + this.circumstantial + this.item + this.status + this.untyped + this.ACBase;
        }
    }
}
