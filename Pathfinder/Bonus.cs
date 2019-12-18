using System;
using System.Collections.Generic;
using System.Text;


/* TODO
 * Add Profiencey interface
 * Increase attributes
 * Add penalties
 */
namespace Pathfinder
{
    public class Bonus
    {
        internal Proficiency proficiency;
        internal int level;
        internal int attribute;
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
        public Bonus(Levels pro, int level, int attribute, int cir=0, int ite=0, int stat=0, int unty=0)
        {
            this.level = level;
            this.proficiency = new Proficiency(pro, level);
            this.attribute = attribute;
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
            return this.proficiency.ProficiencyBonus() + this.attribute + this.circumstantial + this.item + this.status + this.untyped;
        }
    }
}
