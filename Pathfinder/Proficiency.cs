using System;
using System.Collections.Generic;
using System.Text;

/* TODO
 * Add increase proficincy level interface
 * add increase level interface
 */

namespace Pathfinder
{
    // Contains the global reference to the profiencies
    public enum Levels { untrained = 0, trained = 2, expert = 4, master = 6, legendary = 8 }
    public class Proficiency
    {
        private Levels Proficient;
        private int PlayerLevel; 
        private bool CheckEnum(string value) => Enum.IsDefined(typeof(Levels), value);

        public int ProficiencyBonus() {
            // The player level is not added to the bonus if they are untrained
            if( this.Proficient == Levels.untrained)
            {
                return PlayerLevel;
            }
            else
            {
                return (int)this.Proficient + this.PlayerLevel;
            }
        }

        public Proficiency(Levels proficient, int level)
        {
            this.Proficient = proficient;
            this.PlayerLevel = level;
        }
    }
}
