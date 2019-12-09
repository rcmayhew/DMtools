using System;

namespace Pathfinder
{
    /* TODO:
     * Add logging
     * Add printing
     */

    class Dice
    {
        private int die_faces;
        private int num_rolls = 1;

        private int SingleRoll(bool verbose = false)
        {
            Random random = new Random();
            return random.Next(1, this.die_faces);

        }

        public int Roll(bool verbose = false, bool logging = false)
        {
            int total = 0;
            for (int i = 0; i < this.num_rolls; ++i)
            {
                total += this.SingleRoll();
            }
            return total;
        }

        public Dice(int faces, int number)
        {
            this.die_faces = faces;
            this.num_rolls = number;
        }

        public Dice()
        {
            this.die_faces = 20;
            this.num_rolls = 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
