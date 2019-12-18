using System;
using System.Collections.Generic;
using System.Text;

namespace Pathfinder
{
    class Attribute
    {
        int score;
        int mod;

        private void CalculateMod()
        {
            //this should be ran everytime score is updated
            this.mod = (this.score - 10) / 2; //because of int trucation, this should be the same as floor 
        }
        Attribute()
        {
            this.score = 10;
            this.CalculateMod();
        }

        Attribute(int score)
        {
            this.score = score;
            this.CalculateMod();
        }

        public int GetScore()
        {
            return this.score;
        }

        public int GetMod()
        {
            return this.mod;
        }
    }
}
