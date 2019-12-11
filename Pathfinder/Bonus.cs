using System;
using System.Collections.Generic;
using System.Text;

namespace Pathfinder
{
    public class Bonus
    {
        internal Proficiency proficiency;
        internal int level;
        internal int att;
        internal int circumstantial;
        internal int item;
        internal int status;
        internal int untyped;

        internal int forced = 0;

        public Bonus()
        {
            this.level = 1;
            this.proficiency = new Proficiency(Levels.untrained, 1);
            this.circumstantial = 0;
            this.item = 0;
            this.status = 0;
            this.untyped = 0;
        }
        public Bonus(Levels pro, int lev, int at, int cir=0, int ite=0, int stat=0, int unty=0)
        {
            this.level = lev;
            this.proficiency = new Proficiency(pro, lev);
            this.att = at;
            this.circumstantial = cir;
            this.item = ite;
            this.status = stat;
            this.untyped = unty;
        }

        public void Force(int num)
        {
            this.forced = num;
        }

        public int FinalBonus()
        {
            if (forced != 0)
            {
                return forced;
            }
            return this.proficiency.ProficiencyBonus() + this.level + this.att + this.circumstantial + this.item + this.status + this.untyped;
        }
    }
}
